using AkarSoftware.Parking.Core.DataAccess.EntityFramework.Abstract;
using AkarSoftware.Parking.Entities.Concrete.Parking;

namespace AkarSoftware.Parking.DataAccess.EntityFramework.Abstract
{
    public interface ICarParkRepository : IEfGenericRepository<CarPark>
    {
        Task CostumeMethod();
    }
}
