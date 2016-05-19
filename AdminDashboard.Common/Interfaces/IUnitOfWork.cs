namespace AdminDashboard.Common.Interfaces
{
    public interface IUnitOfWork
    {
        object Context { get; }
        /// <summary>
        /// Begins the transaction
        /// </summary>
        void BeginTransaction();
        /// <summary>
        /// Commits the changes to the underlying data store.
        /// </summary>
        void Commit();
        /// <summary>
        /// Rollbacks all changes to the entities in the model.
        /// </summary>
        void Rollback();
        /// <summary>
        /// Gets the repository context
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        //IRepository<T> Repository<T>() where T : class;
    }
}
