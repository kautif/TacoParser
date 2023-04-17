using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingKata
{
    public class Tacobell : ITrackable
    {
        public string Name { get; set; }
        public Point Location { get; set; }
        public Tacobell() { }
        public Tacobell(string name, double latitude, double longitude) 
        {
            Name = name;
            Location = new Point(latitude, longitude);
        }

    }
}
