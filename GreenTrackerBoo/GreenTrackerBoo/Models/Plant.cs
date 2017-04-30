using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GreenTrackerBoo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    [Table("Plant")]
    public partial class Plant
    {
        
        public Plant()
        {
            this.Occurrence = new HashSet<Occurrence>();
            this.Report = new HashSet<Report>();
        }

        [Key]
        public string PlantID { get; set; }
        public string CommonName { get; set; }
        public string ScientificName { get; set; }
        public string Description { get; set; }
        public string PageLink { get; set; }
    
        public virtual ICollection<Occurrence> Occurrence { get; set; }
        public virtual ICollection<Report> Report { get; set; }
    }
}
