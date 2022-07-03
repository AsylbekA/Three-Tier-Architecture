using Data.Repositories.Abstract;
using Domain;
using Mapper;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class VehicleService : IVehicleService
    {
        private readonly IVehiclesRepository _vehicleRepository;
        public VehicleService(IVehiclesRepository vehiclesRepository)
        {
            _vehicleRepository = vehiclesRepository;
        }
        public void AddVehicle(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public void DeleteVehicle(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> GetAllVehicles() => VehicleMapper.ToDomainList(_vehicleRepository.GetAllVehicles());

        public Vehicle GetVehicleById(int Id) => VehicleMapper.ToDomain(_vehicleRepository.GetVehicleById(Id));

        public void UpdateVehicle(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
