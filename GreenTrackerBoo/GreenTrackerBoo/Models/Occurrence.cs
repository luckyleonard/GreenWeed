using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GreenTrackerBoo.Models
{
    [Table("Occurrence")]
    public partial class Occurrence
    {
        [Key]
        public int OccurID { get; set; }
        public string PlantID { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }

        public virtual Plant Plant { get; set; }
    }
}