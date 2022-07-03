using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class VehicleEntity:BaseEntity
    {
        public string Model { get; set; }
        public string GovermentNumber { get; set; }
        public int DriverId { get; set; }
    }
}
