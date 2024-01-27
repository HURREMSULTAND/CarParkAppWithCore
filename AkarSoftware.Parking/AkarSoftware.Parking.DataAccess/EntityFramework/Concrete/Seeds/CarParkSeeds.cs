using AkarSoftware.Parking.Entities.Concrete.Parking;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.Parking.DataAccess.EntityFramework.Concrete.Seeds
{
    internal class CarParkSeeds : IEntityTypeConfiguration<CarPark>
    {
        public void Configure(EntityTypeBuilder<CarPark> builder)
        {
            builder.HasData(
          new CarPark { Id = 1, CarParkName = "Sağmalcılar Otoparkı", IsActive = true, UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now, AppUserId = 1 },
          new CarPark { Id = 2, CarParkName = "Bayrampaşa Otoparkı", IsActive = true, UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now, AppUserId = 1 },
          new CarPark { Id = 3, CarParkName = "Esenler Otoparkı", IsActive = true, UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now, AppUserId = 1 },
          new CarPark { Id = 4, CarParkName = "Yüreğir Otoparkı", IsActive = true, UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now, AppUserId = 1 },
          new CarPark { Id = 5, CarParkName = "Hürreiyet Otoparkı", IsActive = true, UpdatedDate = DateTime.Now, CreatedDate = DateTime.Now, AppUserId = 1 }
          );
        }
    }
}
