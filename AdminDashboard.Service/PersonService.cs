using AdminDashboard.Common.Interfaces;
using AdminDashboard.DAL.EF;
using AdminDashboard.Entities.Models;

namespace AdminDashboard.Service
{
    public class PersonService : EntityService<Person>, IPersonService
    {
        private readonly IPersonRepository _personRepository;
        public PersonService(IUnitOfWork uow, IRepository<Person> repository) : base(uow, repository)
        {
            _personRepository = (IPersonRepository) repository;
        }

        public Person GetById(long id)
        {
            return _personRepository.GetPersonById(id);
        }
    }
}
