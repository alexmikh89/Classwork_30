using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_30
{
    class Program 
    {
        static void Main(string[] args)
        {
            using (var context= new HumanResourcesEntities())
            {
                foreach (var item in context.employees.ToList())                
                {
                    Console.WriteLine(item.last_name + ", "+ item.first_name);
                }
            }

            Console.ReadKey();
        }
    }
}
