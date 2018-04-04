using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Course_App.Models
{
    public class Animal
    {
        public string Species { get; set; }
        public string Genus { get; set; }
        public int NumberOfLegs { get; set; }
        public override string ToString()
        {
            return string.Format("Hello, I am a {0} with {1} legs from the {2} family.", this.Species, this.NumberOfLegs.ToString(), this.Genus);
        }
    }
}