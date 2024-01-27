using AkarSoftware.Parking.Business.Abstract;
using AkarSoftware.Parking.Business.Concrete.Managers;
using AkarSoftware.Parking.DataAccess.EntityFramework.Abstract;
using AkarSoftware.Parking.DataAccess.EntityFramework.Concrete.Contexts;
using AkarSoftware.Parking.DataAccess.EntityFramework.Concrete.UOW;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AkarSoftware.Parking.Business.Concrete.DependencyResolves.Microsoft
{
    public static class CostumeMicrosoftIOC
    {
        public static void AddCostumeDependencies(this IServiceCollection Service)
        {
            //Service.AddScoped<IUnitOfWork, UnitOfWork>();
            //Service.AddScoped<ICarParkService, CarParkManager>();
            Service.AddDbContext<AppDbContext>(x =>
            {
                //Server = > . localhost localhos/mssqlserver, ip 
                // Database => ParkingApp
                // Dontet 6 ve sonrasında TrustedSerticiation 

                x.UseSqlServer("server = 192.168.1.200; database=ParkingApp; user id =sa; password=Qwerasdf0147;TrustServerCertificate=Yes;");

            });

        }
    }
}
