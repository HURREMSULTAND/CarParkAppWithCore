using AkarSoftware.Parking.Entities.Concrete.Parking;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.Parking.DataAccess.EntityFramework.Concrete.Configurations
{
    internal class CarParksConfiguration : IEntityTypeConfiguration<CarPark>
    {
        public void Configure(EntityTypeBuilder<CarPark> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CarParkName).HasMaxLength(200);

      
        }
    }
}
