using RestASPNET_NET5.Model;

namespace RestASPNET_NET5.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person Disable(long id);
    }
}
