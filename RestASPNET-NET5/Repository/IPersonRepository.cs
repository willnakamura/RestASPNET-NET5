﻿using RestASPNET_NET5.Model;
using System.Collections.Generic;

namespace RestASPNET_NET5.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
        bool Exists(long id);
    }
}
