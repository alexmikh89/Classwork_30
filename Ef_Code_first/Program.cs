using BuisnessLogic;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_Code_first
{
    public class Program
    {
        static void Main(string[] args)
        {
            ShopManager manager = new ShopManager();

            var shops = manager.GetShops();

            //foreach (var shop in shops)
            //{
            //    Console.WriteLine($"Name: {shop.Name}");
            //    foreach (var sup in shop.Suppliers)
            //    {
            //        Console.WriteLine($"Supplier Name: {sup.Name}");
            //        foreach (var prod in sup.Products)
            //        {
            //            Console.WriteLine($"Product Name: {prod.Name}");
            //        }
            //    }

            //}

            Console.WriteLine("----------------------------");

            var sh = manager.GetFirstShop();


            Console.ReadKey();
        }
    }
}
