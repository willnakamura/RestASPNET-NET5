using RestASPNET_NET5.Model;
using System.Collections.Generic;

namespace RestASPNET_NET5.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person Disable(long id);
        List<Person> FindByName(string firstName, string secondName);
    }
}
