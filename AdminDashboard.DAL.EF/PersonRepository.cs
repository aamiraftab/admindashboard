using AdminDashboard.Common.Interfaces;
using AdminDashboard.Entities.Models;

namespace AdminDashboard.DAL.EF
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(IUnitOfWork uow) : base(uow)
        {
        }

        public Person GetPersonById(long id)
        {
            return GetById(id);
        }
    }
}
