using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GREENWEED_4.Models
{
    public class Plants
    {
        public int PlantID { get; set; }
        public string CommonName { get; set; }
        public string ScientificName { get; set; }
        public int Postcode { get; set; }
    }
}