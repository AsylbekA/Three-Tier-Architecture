using Data.Repositories.Abstract;
using Domain;
using Entities;
using Mapper;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class DiverService : IDiverService
    {
        private readonly IDriversRepository _driversRepository;
        public DiverService(IDriversRepository driversRepository)
        {
            _driversRepository = driversRepository;
        }
        public void AddDriver(Driver driver)
        {
            throw new NotImplementedException();
        }

        public void DeleteDriver(int id)
        {
            throw new NotImplementedException();
        }

        public Driver GetDriverById(int id) => DriverMapper.ToDomain(_driversRepository.GetDriverById(id));


        public void UpdateDriver(Driver driver)
        {
            throw new NotImplementedException();
        }
    }
}
