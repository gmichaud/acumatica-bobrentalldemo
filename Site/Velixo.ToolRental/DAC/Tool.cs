﻿using System;
using PX.Data;

namespace Velixo.ToolRental
{
    [Serializable]
    public class Tool : PX.Data.IBqlTable
    {
        public abstract class toolCD : PX.Data.IBqlField { }
        [PXDBString(30, IsKey = true, IsUnicode = true)]
        [PXDefault()]
        [PXUIField(DisplayName = "Tool Code")]
        [PXSelector(typeof(Search<Tool.toolCD>))]
        public virtual string ToolCD { get; set; }

        public abstract class description : PX.Data.IBqlField { }
        [PXDBString(50, IsUnicode = true)]
        [PXDefault]
        [PXUIField(DisplayName = "Description", Visibility=PXUIVisibility.SelectorVisible)]
        public virtual string Description { get; set; }

        public abstract class cost : PX.Data.IBqlField { }
        [PXDBDecimal(2)]
        [PXUIField(DisplayName = "Cost")]
        public virtual decimal? Cost { get; set; }

        public abstract class serialNumber : PX.Data.IBqlField { }
        [SerialNumber]
        public virtual string SerialNumber { get; set; }

        public abstract class noteID : PX.Data.IBqlField {}
        [PXSearchable(PX.Objects.SM.SearchCategory.SO, "{0} - {1}", new Type[] { typeof(Tool.toolCD), typeof(Tool.description) },
           new Type[] { typeof(Tool.toolCD), typeof(Tool.description) },
           Line1Format = "{0}{1}", Line1Fields = new Type[] { typeof(Tool.toolCD), typeof(Tool.description) })]
        [PXNote]
        public virtual Guid NoteID { get; set; }
    }
}