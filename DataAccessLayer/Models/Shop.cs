using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Shop
    {
        public Shop()
        {
            Suppliers = new List<Supplier>();
        }
        public int ID { get; set; }
        public string ShopName { get; set; }

        public virtual ICollection<Supplier> Suppliers{ get; set; }
    }
}
