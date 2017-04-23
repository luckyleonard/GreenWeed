using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GreenTrackerBoo.Models
{
    public class PlantContext : DbContext
    {
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Occurrence> Occurrences { get; set; }
        public DbSet<Report> Reports { get; set; }
    }


}