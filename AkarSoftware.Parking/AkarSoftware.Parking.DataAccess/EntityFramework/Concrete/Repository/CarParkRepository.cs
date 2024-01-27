using AkarSoftware.Parking.Core.DataAccess.EntityFramework.Concrete;
using AkarSoftware.Parking.DataAccess.EntityFramework.Abstract;
using AkarSoftware.Parking.DataAccess.EntityFramework.Concrete.Contexts;
using AkarSoftware.Parking.Entities.Concrete.Parking;

namespace AkarSoftware.Parking.DataAccess.EntityFramework.Concrete.Repository
{
    public class CarParkRepository : EfGenericRepository<CarPark>, ICarParkRepository
    {
        public CarParkRepository(AppDbContext context) :base(context) 
        {
           
        }
        public Task CostumeMethod()
        {
            // İlgili alan Sadece Costume MEthodlar oluşturulup kullanılmak istenirse diye oluşturulmuş olan bir örnektir
            // MEthod geçersiz bir methoddur
            throw new NotImplementedException();
        }
    }
}
