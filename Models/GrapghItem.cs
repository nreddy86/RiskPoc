using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ARUP.Models
{
    public class GrapghItem
    {
        public string Title { get; set; }
        public string value { get; set; }
        public string Colour { get; set; }
        public string CssClass { get; set; }
        public int Low { get; set; }
        public int Medium { get; set; }
        public int High { get; set; }
    }
}