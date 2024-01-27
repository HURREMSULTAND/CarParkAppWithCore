using AkarSoftware.Parking.Core.DataAccess.EntityFramework.Abstract;
using AkarSoftware.Parking.Core.Entities.Abstract;
using AkarSoftware.Parking.Core.Utilities.Pagination.ComplexTypes;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AkarSoftware.Parking.Core.DataAccess.EntityFramework.Concrete
{
    public class EfGenericRepository<T> : IEfGenericRepository<T> where T : class, IEntity, new()
    {
        private readonly DbContext _DbContext;
        private readonly DbSet<T> _Entity;
        public EfGenericRepository(DbContext DbContext)
        {
            _DbContext = DbContext;
            _Entity = _DbContext.Set<T>();
        }
        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            return await _Entity.AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate = null)
        {
            return await _Entity.CountAsync(predicate);
        }

        public async Task<T> CreateAsync(T Entity)
        {
            await _Entity.AddAsync(Entity);
            return Entity;
        }

        public async Task DeleteAsync(T Entity)
        {
            await Task.Run(()=>
            {
                _Entity.Update(Entity);
            });
            
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> where = null, bool AsNoTracking = true, params Expression<Func<T, object>>[] IncludeProperties)
        {
            IQueryable<T> query = _Entity;

            if (IncludeProperties != null)

                foreach (var item in IncludeProperties)
                    query = query.Include(item);

            if (where != null)
                query = query.Where(where);


            if (AsNoTracking == true)
                query = query.AsNoTracking();

            return await query.ToListAsync();

        }

        public async Task<List<T>> GetAllAsyncWithListExpression(IList<Expression<Func<T, bool>>> where = null, bool AsNoTracking = true, params Expression<Func<T, object>>[] IncludeProperties)
        {
            IQueryable<T> query = _Entity;

            if (IncludeProperties != null)

                foreach (var item in IncludeProperties)
                    query = query.Include(item);

            if (where != null)
                foreach (var item in where)
                    query = query.Where(item);


            if (AsNoTracking == true)
                query = query.AsNoTracking();

            return await query.ToListAsync();
        }

        public async Task<PagedList<T>> GetAllWithPagingAsync(RequestParameters parameters, Expression<Func<T, bool>> where = null, bool AsNoTracking = true, params Expression<Func<T, object>>[] IncludeProperties)
        {
            IQueryable<T> query = _Entity;

            if (IncludeProperties != null)

                foreach (var item in IncludeProperties)
                    query = query.Include(item);

            if (where != null)
                query = query.Where(where);


            if (AsNoTracking == true)
                query = query.AsNoTracking();

            #region GenericPaging
            var queryCount = query.Count(); // Total Nesne Sayısı 
            var Model = await query.Skip((parameters.PageNumber - 1) * parameters.PageSize).Take(parameters.PageSize).ToListAsync(); // seçilen sayfanın bir öncesi * sayfanın toplam içeriği ve sonrasında Take ile ne kadar alacağım burada belirlenmiştir. 
            #endregion
            return PagedList<T>.ToPagedList(Model, parameters.PageNumber, parameters.PageSize, queryCount);


        }

        public async Task<PagedList<T>> GetAllWithPagingAsync(RequestParameters parameters, IList<Expression<Func<T, bool>>> where = null, bool AsNoTracking = true, Expression<Func<T, object>> OrderByProperty = null, params Expression<Func<T, object>>[] IncludeProperties)
        {
            IQueryable<T> query = _Entity;

            if (IncludeProperties != null)

                foreach (var item in IncludeProperties)
                    query = query.Include(item);

            if (where != null)
                foreach (var item in where)
                {
                    query = query.Where(item);
                }


            if (AsNoTracking == true)
                query = query.AsNoTracking();

            #region GenericPaging
            var queryCount = query.Count(); // Total Nesne Sayısı 
            var Model = await query.Skip((parameters.PageNumber - 1) * parameters.PageSize).Take(parameters.PageSize).ToListAsync(); // seçilen sayfanın bir öncesi * sayfanın toplam içeriği ve sonrasında Take ile ne kadar alacağım burada belirlenmiştir. 
            #endregion
            return PagedList<T>.ToPagedList(Model, parameters.PageNumber, parameters.PageSize, queryCount);
        }

        public IQueryable<T> GetAsQueryable()
        {
            return _Entity.AsQueryable();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> where = null, bool AsNoTracking = false, params Expression<Func<T, object>>[] IncludeProperties)
        {
            IQueryable<T> query = _Entity;
            if (IncludeProperties != null)

                foreach (var item in IncludeProperties)
                    query = query.Include(item);

            if (where != null)
                query = query.Where(where);


            if (AsNoTracking == true)
                query = query.AsNoTracking();

            return await query.FirstOrDefaultAsync();
        }

        public async Task SoftDeleteAsync(T Entity)
        {
            await Task.Run(() =>
            {
                Entity.IsActive = false;
                _Entity.Update(Entity);
            });
        }

        public async Task UpdateAsync(T Entity)
        {
            await Task.Run(() =>
            {
                _Entity.Update(Entity);
            });
        }
    }
}
