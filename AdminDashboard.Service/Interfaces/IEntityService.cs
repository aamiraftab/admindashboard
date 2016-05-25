using System.Collections.Generic;

namespace AdminDashboard.Service.Interfaces
{
    public interface IEntityService<T>
    {
        void Create(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        void Update(T entity);
    }
}
