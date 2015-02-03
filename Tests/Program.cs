using System;
using Core.Login;
using Core.TestExecution;
using Core.Log;

namespace Velixo.ToolRental.Tests
{
    public class Test : Check
    {
        public override void Execute()
        {
            PxLogin.LogIn("admin", "admin");
            var toolsForm = new ToolManagement();
            toolsForm.OpenScreen();

            toolsForm.Insert();
            toolsForm.Summary.ToolCD.Type("ABC");
            toolsForm.Summary.Description.Type("My new tool");
            toolsForm.Summary.SerialNumber.Type("XYZ"); //System should complain that serial number doesn't start with BOB-.

            try
            {
                toolsForm.Save();
                Log.Error("Tool should not have saved, serial number is invalid");
            }
            catch(Exception e)
            {
                Log.Information(e.Message);
            }

            toolsForm.Summary.SerialNumber.Type("BOB-1234");
            toolsForm.Save();
            Log.Information("Test completed!");
        }
    }
}