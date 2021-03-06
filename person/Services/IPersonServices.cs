﻿using person.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace person.Services
{
    public interface IPersonServices
    {
        Person Create(Person person);
        Person FindById(long id);
        List <Person> FindAll();
        Person Update(Person person);
        void Delete(long id);

    }
}
