using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst
{
    public class CustomInitializer : DropCreateDatabaseAlways<PersonContext>
    {
        protected override void Seed(PersonContext context)
        {
            var peopleCollection = new List<Person>()
            {
                new Person (){Age=20},
                new Person() {Name = "Ivan"}
            };

            context.People.AddRange(peopleCollection);
            context.SaveChanges();
        }
    }
}
