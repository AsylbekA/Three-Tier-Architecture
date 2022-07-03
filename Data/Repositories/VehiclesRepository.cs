using Data.Repositories.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class VehiclesRepository : IVehiclesRepository
    {
        public List<VehicleEntity> GetAllVehicles()
        {
            throw new NotImplementedException();
        }

        public VehicleEntity GetVehicleById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
