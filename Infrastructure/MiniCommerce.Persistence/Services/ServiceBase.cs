using MiniCommerce.Application.Repositories;
using MiniCommerce.Application.Services;
using MiniCommerce.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Persistence.Services
{
    public partial class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : BaseEntity
    {
        #region Fields

        private readonly IReadRepository<TEntity> _entityReadRepository;
        private readonly IWriteRepository<TEntity> _entityWriteRepository;

        #endregion

        #region Ctor

        public ServiceBase(IReadRepository<TEntity> entityReadRepository, IWriteRepository<TEntity> entityWriteRepository)
        {
            _entityReadRepository = entityReadRepository;
            _entityWriteRepository = entityWriteRepository;

        }

        #endregion

        #region Methods

        #region Select
        public IQueryable<TEntity> GetAll(bool tracking = true)
        {

            return _entityReadRepository.GetAll(tracking);
        }

        public virtual async Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> method, bool tracking = true)
        {

            return await _entityReadRepository.GetSingleAsync(method);
        }

        public virtual IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> method, bool tracking = true)
        {
            return _entityReadRepository.GetWhere(method, tracking);
        }

        public virtual async Task<TEntity> GetByIdAsync(int id, bool tracking = true)
        {
            if (id ==0 )
                return null;

            return await _entityReadRepository.GetByIdAsync(id, tracking);
        }

        //public virtual IPagedList<TEntity> GetPagedEntities(Expression<Func<TEntity, bool>> predicate = null, string includeString = null, int pageIndex = 0, int pageSize = int.MaxValue, Sort sort = null)
        //{
        //    var query = _entityReadRepository.Table.AsQueryable();

        //    if (sort != null)
        //        query = query.Sort(sort);
        //    else
        //        query = query.OrderBy(c => c.Id);

        //    return new PagedList<TEntity>(query, pageIndex, pageSize);
        //}

        #endregion

        #region Insert

        public virtual async Task<bool> AddAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            return await _entityWriteRepository.AddAsync(entity);
        }

        public virtual async Task<bool> AddRangeAsync(List<TEntity> datas)//IEnumerable<TEntity> entities
        {
            if (datas == null)
                throw new ArgumentNullException(nameof(datas));

            await _entityWriteRepository.AddRangeAsync(datas);
            return true;
        }

        #endregion

        #region Update

        public virtual bool Update(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _entityWriteRepository.Update(entity);
            return true;

        }

        #endregion

        #region Delete
        public bool Remove(TEntity model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));
            _entityWriteRepository.Remove(model);
            return true;
        }

        public virtual async Task<bool> RemoveAsync(string id)
        {

            if (id.Equals(0))
                throw new ArgumentNullException(nameof(id));

            await _entityWriteRepository.RemoveAsync(id);
            return true;

        }

        public virtual bool RemoveRange(List<TEntity> data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            _entityWriteRepository.RemoveRange(data);
            return true;
        }

        public virtual async Task<int> SaveAsync()
        {
            return await _entityWriteRepository.SaveAsync();
        }



        #endregion

        #endregion
    }
}
