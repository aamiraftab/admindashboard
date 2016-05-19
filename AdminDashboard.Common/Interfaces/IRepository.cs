using System.Collections.Generic;

namespace AdminDashboard.Common.Interfaces
{
    public interface IRepository<T>
    { 
        /// <summary>
        /// Adds the entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        void Add(T entity);
        /// <summary>
        /// Updates the entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        void Update(T entity);
        /// <summary>
        /// Deletes the entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        void Delete(T entity);
        /// <summary>
        /// Get the entity
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(long id);
        /// <summary>
        /// Gets the list
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();
    }
}
