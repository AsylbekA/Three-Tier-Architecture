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
    public static class DriverMapper
    {
        public static DriverEntity ToEntity(this Driver driver)
        {
            return new DriverEntity
            {
                Age = driver.Age,
                Name = driver.Name
            };
        }


        public static Driver ToDomain(this DriverEntity driverentity)
        {
            return new Driver
            {
                Age = driverentity.Age,
                Name = driverentity.Name
            };
        }
        public static Driver ToDomain(this DriversModel drivermodel)
        {
            return new Driver
            {
                Age = drivermodel.Age,
                Name = drivermodel.Name,
                //Vehicles = drivermodel.Vehicles.Select(x}).ToList()
            };
        }
    }
}
