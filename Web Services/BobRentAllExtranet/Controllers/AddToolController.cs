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
    }
}