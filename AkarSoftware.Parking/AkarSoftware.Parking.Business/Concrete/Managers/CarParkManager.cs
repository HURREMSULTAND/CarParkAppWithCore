using AkarSoftware.Parking.Business.Abstract;
using AkarSoftware.Parking.Core.Utilities.Results.BaseResult;
using AkarSoftware.Parking.Core.Utilities.Results.ComplexTypes;
using AkarSoftware.Parking.DataAccess.EntityFramework.Abstract;
using AkarSoftware.Parking.Dtos.Concrete.Parking.CarPark;
using AkarSoftware.Parking.Entities.Concrete.Parking;
using AutoMapper;

namespace AkarSoftware.Parking.Business.Concrete.Managers
{
    public class CarParkManager : BaseManager, ICarParkService
    {

        public CarParkManager(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<IDataResult<List<CarParkListDto>>> GetAllParkList()
        {
            var repository = unitOfWork.GetGenericRepository<CarPark>();
            var Datas = await repository.GetAllAsyncWithListExpression();
            if (Datas == null)
                return new DataResult<List<CarParkListDto>>(default, ResultStatus.NotFound, "Sistemde Kayıtı ürün bulunamadı");

            var Dtos = mapper.Map<List<CarParkListDto>>(Datas);
            if (Dtos == null)
                return new DataResult<List<CarParkListDto>>(default, ResultStatus.MappingError, "Tür Dönüşümü Hatası Alındı");

            return new DataResult<List<CarParkListDto>>(Dtos, ResultStatus.Success, "Sistemde Kayıtı ürün bulunamadı");

        }
    }
}
