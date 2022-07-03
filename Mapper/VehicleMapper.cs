using Domain;
using Entities;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public static class VehicleMapper
    {
        public static VehicleEntity ToEntity(this Vehicle vehicle)
        {
            return new VehicleEntity
            {
                Model = vehicle.Model,
                DriverId = vehicle.DriverId,
                GovermentNumber = vehicle.GovermentNumber
            };
        }

        public static Vehicle ToDomain(this VehicleEntity vehicleentity)
        {
            return new Vehicle
            {
                Model = vehicleentity.Model,
                DriverId = vehicleentity.DriverId,
                GovermentNumber = vehicleentity.GovermentNumber
            };
        }

        public static Vehicle ToDomain(this VehicleModel vehicleentity)
        {
            return new Vehicle
            {
                Model = vehicleentity.Model,
                DriverId = vehicleentity.DriverId,
                GovermentNumber = vehicleentity.GovermentNumber
            };
        }

        public static List<Vehicle> ToDomainList(this List<VehicleEntity> vehicleentity)
        {
            List<Vehicle> list = new List<Vehicle>();
            foreach (var item in vehicleentity)
            {
                list.Add(ToDomain(item));
            }
            return list;
        }
    }
}
