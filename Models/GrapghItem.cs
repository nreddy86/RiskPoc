using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ARUP.Models
{
    public class GrapghItem
    {
        public string Title { get; set; }
        public string Value { get; set; }
        public string Percentage { get; set; }
        public string Color { get; set; }
        public string CssClass { get; set; }
        public int Low { get; set; }
        public int Medium { get; set; }
        public int High { get; set; }
    }
}