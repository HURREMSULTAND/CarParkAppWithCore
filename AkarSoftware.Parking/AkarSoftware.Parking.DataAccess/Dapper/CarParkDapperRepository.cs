using AkarSoftware.Parking.Core.Utilities.Pagination.ComplexTypes;
using AkarSoftware.Parking.DataAccess.EntityFramework.Abstract;
using AkarSoftware.Parking.Entities.Concrete.Parking;
using Microsoft.Data.SqlClient;
using System.Linq.Expressions;

namespace AkarSoftware.Parking.DataAccess.Dapper
{
    public class CarParkDapperRepository : ICarParkRepository
    {
        public async Task<bool> AnyAsync(Expression<Func<CarPark, bool>> predicate)
        {
            SqlConnection connection = new SqlConnection();
            return false;
        }

        public Task CostumeMethod()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<CarPark, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Task<CarPark> CreateAsync(CarPark Entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(CarPark Entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<CarPark>> GetAllAsync(Expression<Func<CarPark, bool>> where = null, bool AsNoTracking = true, params Expression<Func<CarPark, object>>[] IncludeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<List<CarPark>> GetAllAsyncWithListExpression(IList<Expression<Func<CarPark, bool>>> where = null, bool AsNoTracking = true, params Expression<Func<CarPark, object>>[] IncludeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<PagedList<CarPark>> GetAllWithPagingAsync(RequestParameters parameters, Expression<Func<CarPark, bool>> where = null, bool AsNoTracking = true, params Expression<Func<CarPark, object>>[] IncludeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<PagedList<CarPark>> GetAllWithPagingAsync(RequestParameters parameters, IList<Expression<Func<CarPark, bool>>> where = null, bool AsNoTracking = true, Expression<Func<CarPark, object>> OrderByProperty = null, params Expression<Func<CarPark, object>>[] IncludeProperties)
        {
            throw new NotImplementedException();
        }

        public IQueryable<CarPark> GetAsQueryable()
        {
            throw new NotImplementedException();
        }

        public Task<CarPark> GetAsync(Expression<Func<CarPark, bool>> where = null, bool AsNoTracking = false, params Expression<Func<CarPark, object>>[] IncludeProperties)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteAsync(CarPark Entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CarPark Entity)
        {
            throw new NotImplementedException();
        }
    }
}
