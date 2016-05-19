using System;
using System.Transactions;
using AdminDashboard.Common.Interfaces;

namespace AdminDashboard.DAL.EF
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private TransactionScope _transaction;
        //what about static
        private readonly IDbContext _context;
        private bool _disposed = false;

        public UnitOfWork()
        {
            _context = new SecurityAdminContext();
        }
        public UnitOfWork(IDbContext context)
        {
            _context = context;
        }
        public object Context
        {
            get { return _context; }

        }

        public void BeginTransaction()
        {
            try
            {
                _transaction = new TransactionScope();
            }
            catch (Exception ex)
            {

                throw new Exception(string.Format("An error occurrred during the Begin Transaction.\r\n{0}", ex.Message));
            }
        }
        /// <summary>
        /// Commits the transaction
        /// </summary>
        public void Commit()
        {
            try
            {
                if (_transaction == null)
                {
                    throw new TransactionException("The current transction is not started!");
                }
                _context.SaveChanges();
                _transaction.Complete();
            }
            catch (Exception ex)
            {

                throw new Exception(string.Format("An error occured during the Commit transaction.\r\n{0}", ex.Message));
            }
            finally
            {
                _transaction.Dispose();
            }
        }

        public void Rollback()
        {
            try
            {
                if (_transaction != null)
                {
                    _transaction.Dispose();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(string.Format("An error occured during the Rollback transaction. \r\n{0} ", ex.Message));
            }
        }

        //public IRepository<T> Repository<T>() where T : class
        //{
            
        //    return Func<IRepository<T>, T>() = new T();
        //}

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                _context.Dispose();
            }

            _disposed = true;
        }
    }
}
