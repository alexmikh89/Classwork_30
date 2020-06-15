using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [MaxLength (20)]
        public string ShopName { get; set; }

        public virtual ICollection<Supplier> Suppliers{ get; set; }
    }
}
