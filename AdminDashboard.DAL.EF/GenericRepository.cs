using System.Collections.Generic;
using System.Data.Entity;
using AdminDashboard.Common.Interfaces;

namespace AdminDashboard.DAL.EF
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly IDbContext _dbContext;

        protected GenericRepository(IUnitOfWork uow)
        {
            _dbContext = (IDbContext)uow.Context;
        }
        public virtual void Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
        }

        public virtual void Delete(T entity)
        {
            var entry = _dbContext.Entry(entity);
            entry.State = EntityState.Deleted;
            _dbContext.Set<T>().Remove(entity);
        }

        public virtual T GetById(long id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>();
        }

        public virtual void Update(T entity)
        {
            var entry = _dbContext.Entry(entity);
            _dbContext.Set<T>().Attach(entity);
            entry.State = EntityState.Modified;
        }

       // public abstract int Modified();
    }
}
