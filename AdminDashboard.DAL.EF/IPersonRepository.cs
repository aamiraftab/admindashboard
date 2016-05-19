using AdminDashboard.Common.Interfaces;
using AdminDashboard.Entities.Models;

namespace AdminDashboard.DAL.EF
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person GetPersonById(long id);
    }
}
