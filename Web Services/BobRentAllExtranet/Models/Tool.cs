using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BobRentAllExtranet.Models
{
    public class Tool
    {
        [Required]
        [StringLength(30)]
        [Display(Name="Tool Code")]
        public string ToolCode { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Cost")]
        public decimal Cost { get; set; }

        [StringLength(50)]
        [Display(Name = "Serial Number")]
        public string SerialNumber { get; set; }
    }
}