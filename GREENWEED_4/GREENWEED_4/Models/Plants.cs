using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GREENWEED_4.Models
{
    public class Plants //class for the Plants Entity
    {
        public int PlantID { get; set; } //primary key for plant, unique for each plant
        public string CommonName { get; set; } //plant's common name
        public string ScientificName { get; set; } // plant's scientific name
        public int Postcode { get; set; } // plant's postcoed (will be revised in iteration 2
    }
}