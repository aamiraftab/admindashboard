using AdminDashboard.Entities.Models;

namespace AdminDashboard.Service.Interfaces
{
    public interface IPersonService : IEntityService<Person>
    {
        Person GetById(long id);
    }
}
