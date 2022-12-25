using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> people = new List<PersonModel>();

        public DemoDataAccess()
        {
            people.Add(new PersonModel() { id = 1, FirstName = "Time", LastName = "Corey" });
            people.Add(new PersonModel(){id = 2,FirstName = "Sue",LastName = "Storm"});

        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel p = new PersonModel();
            p = new() { FirstName = firstName, LastName = lastName };
            p.id = people.Max(x => x.id) + 1;
            people.Add(p);

            return p;
        }
    }
}
