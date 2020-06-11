using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic
{
    public class ShopManager
    {
        public IList <Shop> GetShops()
        {
            using (var dbCtx = new ShopContext())
            {
                return dbCtx.Shops.ToList();
            }
        }
    }
}
