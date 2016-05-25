using System;
using System.Collections.Generic;
using AdminDashboard.Common.Interfaces;
using AdminDashboard.Service.Interfaces;

namespace AdminDashboard.Service.Services
{
    public abstract class EntityService<T> : IEntityService<T>
    {
        private IUnitOfWork _unitOfWork;
        private IRepository<T> _repository;

        protected EntityService(IUnitOfWork uow, IRepository<T> repository )
        {
            _unitOfWork = uow;
            _repository = repository;

        } 
        public void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _unitOfWork.BeginTransaction();
            _repository.Add(entity);
            _unitOfWork.Commit();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _unitOfWork.BeginTransaction();
            _repository.Delete(entity);
            _unitOfWork.Commit();

        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _unitOfWork.BeginTransaction();
            _repository.Update(entity);
            _unitOfWork.Commit();
        }
    }
}
