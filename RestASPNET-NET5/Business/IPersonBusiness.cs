using RestASPNET_NET5.Model;
using System.Collections.Generic;

namespace RestASPNET_NET5.Business
{
    public interface IRepositoryBusiness
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
