using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GreenTrackerBoo.Models
{
    [Table("Report")]
    public partial class Report
    {
        [Key]
        public string ReportID { get; set; }
        public string PlantID { get; set; }
        public System.DateTime ReportDate { get; set; }
        public decimal ReportLat { get; set; }
        public decimal ReportLon { get; set; }
        public string AdditionalMessage { get; set; }

        public virtual Plant Plant { get; set; }
    }
}