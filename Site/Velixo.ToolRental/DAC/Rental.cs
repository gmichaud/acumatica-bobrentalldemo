using System;
using PX.Data;
using PX.Objects.AR;

namespace Velixo.ToolRental
{
    [Serializable]
    public class Rental : PX.Data.IBqlTable
    {
        public abstract class rentalID : PX.Data.IBqlField {}
        [PXDBIdentity(IsKey=true)]
        public virtual int RentalID { get; set;  }

        public abstract class toolCD : PX.Data.IBqlField {}
        [PXDBString(30, IsKey = true, IsUnicode = true)]
        [PXDBDefault(typeof(Tool.toolCD))]
        [PXUIField(DisplayName = "Tool Code")]
        public virtual string ToolCD { get; set; } 

        public abstract class customerID : PX.Data.IBqlField {}
        [PXDefault]
        [CustomerActive(Visibility = PXUIVisibility.SelectorVisible, DescriptionField = typeof(Customer.acctName), Filterable = true)]
        public virtual Int32? CustomerID { get; set; }

        public abstract class startDate : PX.Data.IBqlField {}
        [PXDBDate]
        [PXUIField(DisplayName = "Start Date")]
        public virtual DateTime? StartDate { get; set; }

        public abstract class endDate : PX.Data.IBqlField {}
        [PXDBDate]
        [PXUIField(DisplayName = "End Date")]
        public virtual DateTime? EndDate { get; set; }

        public abstract class noteID : PX.Data.IBqlField {}
        [PXNote]
        public virtual Guid NoteID { get; set; }
    }
}