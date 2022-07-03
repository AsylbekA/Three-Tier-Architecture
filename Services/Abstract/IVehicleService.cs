using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IVehicleService
    {
        void AddVehicle(Vehicle vehicle);
        void UpdateVehicle(Vehicle vehicle);
        void DeleteVehicle(int Id);
        Vehicle GetVehicleById(int Id);
        List<Vehicle> GetAllVehicles();
    }
}
