using AkarSoftware.Parking.Core.DataAccess.EntityFramework.Abstract;
using AkarSoftware.Parking.Core.Entities.Abstract;

namespace AkarSoftware.Parking.DataAccess.EntityFramework.Abstract
{
    public interface IUnitOfWork
    {
        #region Costume Repolar için bu şekilde çağrım mümkündür
        ICarParkRepository CarParkRepository { get; }
        #endregion
        void SaveChanges();
        Task SaveChangesAsync();
        IEfGenericRepository<T> GetGenericRepository<T>() where T : class, IEntity, new();

    }
}
