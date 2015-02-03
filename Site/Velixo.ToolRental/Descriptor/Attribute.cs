using PX.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Velixo.ToolRental
{
    [PXDBString(50, IsUnicode = true)]
    [PXUIField(DisplayName = "Serial Number")]
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter | AttributeTargets.Class | AttributeTargets.Method)]
    public class SerialNumberAttribute : PXAggregateAttribute, IPXFieldVerifyingSubscriber
    {
        public void FieldVerifying(PX.Data.PXCache sender, PX.Data.PXFieldVerifyingEventArgs e)
        {
            if(e.NewValue == null || !((string) e.NewValue).StartsWith("BOB-"))
            { 
                throw new PXSetPropertyException("Serial Number must start with BOB-");
            }
        }
    }
}
