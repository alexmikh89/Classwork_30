using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public class Supplier
    {
        public Supplier()
        {
            Products = new List<Product>();
            Shops = new List<Shop>();
        }
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection <Shop> Shops{ get; set; }
        public virtual ICollection<Product> Products{ get; set; }
    }
}
