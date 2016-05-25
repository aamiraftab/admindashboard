using AdminDashboard.Common.Interfaces;
using AdminDashboard.DAL.EF;
using AdminDashboard.Entities.Models;
using AdminDashboard.Service.Interfaces;

namespace AdminDashboard.Service.Services
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
