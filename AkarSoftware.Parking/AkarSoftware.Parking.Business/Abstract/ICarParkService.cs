using AkarSoftware.Parking.Core.Utilities.Results.BaseResult;
using AkarSoftware.Parking.Dtos.Concrete.Parking.CarPark;

namespace AkarSoftware.Parking.Business.Abstract
{
    public interface ICarParkService
    {
        Task<IDataResult<List<CarParkListDto>>> GetAllParkList();
    }
}
