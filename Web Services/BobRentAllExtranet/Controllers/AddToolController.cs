using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BobRentAllExtranet.Controllers
{
    public class AddToolController : Controller
    {
        // GET: AddTool
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(Models.Tool tool)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    AddToolToAcumatica(tool.ToolCode, tool.Description, tool.Cost, tool.SerialNumber);
                    ViewBag.Message = "Your tool has been added!";
                    return View();
                }
                catch (System.Web.Services.Protocols.SoapException ex)
                {
                    ModelState.AddModelError(String.Empty, ex.Message);
                    return View("Index", tool);
                }
            }
            else
            {
                return View("Index", tool);
            }
        }

        private void AddToolToAcumatica(string toolCode, string description, decimal cost, string serialNumber)
        {
            var toolManagement = new VX301000.Screen();
            toolManagement.CookieContainer = new System.Net.CookieContainer();
            toolManagement.Login("admin", "admin");

            var schema = toolManagement.GetSchema();

            var commands = new VX301000.Command[] {
                new VX301000.Value() { LinkedCommand = schema.Tools.ToolCode, Value = toolCode },
                new VX301000.Value() { LinkedCommand = schema.Tools.Description, Value = description },
                new VX301000.Value() { LinkedCommand = schema.Tools.Cost, Value = cost.ToString(System.Globalization.CultureInfo.InvariantCulture) },
                new VX301000.Value() { LinkedCommand = schema.Tools.SerialNumber, Value = serialNumber },
                schema.Actions.Save
            };

            toolManagement.Submit(commands);
        }
    }
}