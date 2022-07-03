using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Driver
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}
