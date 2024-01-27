using AkarSoftware.Parking.Core.DataAccess.EntityFramework.Abstract;
using AkarSoftware.Parking.Core.DataAccess.EntityFramework.Concrete;
using AkarSoftware.Parking.DataAccess.EntityFramework.Abstract;
using AkarSoftware.Parking.DataAccess.EntityFramework.Concrete.Contexts;
using AkarSoftware.Parking.DataAccess.EntityFramework.Concrete.Repository;

namespace AkarSoftware.Parking.DataAccess.EntityFramework.Concrete.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Costume Repository
        public ICarParkRepository CarParkRepository { get { return new CarParkRepository(_appDbContext); } }
        #endregion

        private readonly AppDbContext _appDbContext;

        public UnitOfWork(AppDbContext context)
        {
            _appDbContext = context;
        }
        public void SaveChanges()
        {
            _appDbContext.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }

        IEfGenericRepository<T> IUnitOfWork.GetGenericRepository<T>()
        {
            return new EfGenericRepository<T>(_appDbContext);
        }


        #region İnterface e göre Service gelmesi
        //[Obsolete("Verdiğiniz class a göre ilgili class i dinamik bir şekilde instance aldırır ama artık kullanılamaz.")]
        //public TRepository ReturnRepository<T, TRepository>() where T : BaseEntity, new() where TRepository : IEfGenericRepository<T>, new()
        //{
        //    var repository = (TRepository)Activator.CreateInstance(typeof(TRepository), _dbContexts);
        //    return repository;
        //}
        #endregion

    }
}
