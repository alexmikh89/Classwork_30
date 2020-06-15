using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomInitialiser : 
        //DropCreateDatabaseIfModelChanges<ShopContext>
        CreateDatabaseIfNotExists<ShopContext>
        
    {
        protected override void Seed(ShopContext context)
        {
            var products = new List<Product>()
            {
                new Product (){Name="milk"},
                new Product (){Name="water"}
            };

            var supplier = new Supplier() { Name = "Ivan", Products = products };
            var shop = new Shop() { ShopName = "ATB" };
            shop.Suppliers.Add(supplier);

            context.Products.AddRange(products);
            context.Suppliers.Add(supplier);
            context.Shops.Add(shop);

            context.SaveChanges();
        }
    }
}
