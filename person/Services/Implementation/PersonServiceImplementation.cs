using person.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace person.Services.Implementation
{
    public class PersonServiceImplementation : IPersonServices
    {
        private volatile int count; 

        
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++) 
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Random Name" + i,
                LastName = "Random Last Name" + i,
                Addres = "Random Addres" + i,
                Gender = "Male"
            };
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Rafael",
                LastName = "Dresch",
                Addres = "",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
    
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
