using Domain;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class DriversServiceLoggerDecorator : IDiversService
    {
        private readonly IDiversService _diversService;
        public DriversServiceLoggerDecorator(IDiversService diversService)
        {
            _diversService = diversService;
        }

        public void AddDriver(Driver driver)
        {
            _diversService.AddDriver(driver);
        }

        public void DeleteDriver(int id)
        {
            throw new NotImplementedException();
        }

        public Driver GetDriverById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateDriver(Driver driver)
        {
            throw new NotImplementedException();
        }
    }
}
