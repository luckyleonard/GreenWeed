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
        public int ReportID { get; set; }
        public string PlantID { get; set; }
        public Nullable<double> ReportLat { get; set; }
        public Nullable<double> ReportLon { get; set; }
        public string AdditionalMessage { get; set; }
        public string userEmail { get; set; }
        public string userName { get; set; }
        public string ReportDate { get; set; }

        public virtual Plant Plant { get; set; }
    }
}