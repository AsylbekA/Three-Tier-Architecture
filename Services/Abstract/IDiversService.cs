using Domain;

namespace Services.Abstract
{
   public interface IDiversService
    {
        void AddDriver(Driver driver);
        void UpdateDriver(Driver driver);
        Driver GetDriverById(int id);
        void DeleteDriver(int id);

    }
}
