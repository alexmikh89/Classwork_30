using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst
{
    public class PersonContext : DbContext
    {
        public PersonContext() : base ("DefaultConnection")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<PersonContext>());
        }
       public DbSet<Person> People { get; set; }
    }
}
