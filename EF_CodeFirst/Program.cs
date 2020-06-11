using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst
{
  public  class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new PersonContext())
            {
                ctx.People.Add(new Person() { Age = 20, Name = "oleksii" });
                ctx.SaveChanges();
            }
            Console.WriteLine("Ready");
            Console.ReadKey();
        }
    }
}
