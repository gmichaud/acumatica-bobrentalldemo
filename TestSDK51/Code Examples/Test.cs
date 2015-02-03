using System;
using Core.Login;
using Core.TestExecution;
using TestAcumatica.Extension;

namespace TestAcumatica
{
    public class Test : Check
    {
        public override void Execute()
        {
            PxLogin.LogIn("admin", "123");

            var batch = new Batch();

            batch.OpenScreen();
            batch.Insert();
            batch.Summary.Module.Select("GL");
            batch.Summary.DateEntered.Type(new DateTime(2014, 10, 27));
            batch.Summary.BranchID.Select("MAIN");
            batch.Summary.LedgerID.Select("ACTUAL");
            batch.Summary.CuryID.Select("USD");
            batch.Summary.AutoReverse.SetFalse();
            batch.Summary.AutoReverseCopy.SetFalse();
            batch.Summary.Description.Type("My 1-st Test Batch");

            batch.Details.New();
            batch.Details.Row.AccountID.Select("100000");
            batch.Details.Row.SubID.TypeKeys("US000000000");
            batch.Details.Row.ProjectID.Select("ATTRUSE001");
            batch.Details.Row.TaskID.Select("1");
            batch.Details.Row.RefNbr.Type("1");
            batch.Details.Row.CuryDebitAmt.Type(100);
            batch.Details.Row.CuryCreditAmt.Type(0);

            batch.Details.New();
            batch.Details.Row.AccountID.Select("101000");
            batch.Save();
            batch.Release();
        }
    }
}