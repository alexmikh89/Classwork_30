using System.Collections.Generic;

namespace BuisnessLogic.ModelsDTO
{
    public class SupplierDTO
    {
        public SupplierDTO()
        {
            Products = new List<ProductDTO>();
            Shops = new List<ShopDTO>();
        }
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ShopDTO> Shops { get; set; }
        public virtual ICollection<ProductDTO> Products { get; set; }
    }
}
