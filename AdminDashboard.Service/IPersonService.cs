using AdminDashboard.Entities.Models;

namespace AdminDashboard.Service
{
    public interface IPersonService : IEntityService<Person>
    {
        Person GetById(long id);
    }
}
