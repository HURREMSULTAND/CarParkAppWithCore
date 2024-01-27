using AkarSoftware.Parking.Entities.Concrete.Parking;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AkarSoftware.Parking.DataAccess.EntityFramework.Concrete.Contexts
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }



        public DbSet<CarPark> CarParks { get; set; }
        public DbSet<ParkingArea> ParkingArea { get; set; }
        public DbSet<ParkLayers> ParkLayers { get; set; }






    }
}
