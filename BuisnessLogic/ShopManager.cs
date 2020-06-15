using AutoMapper;
using BuisnessLogic.ModelsDTO;
using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BuisnessLogic
{
    public class ShopManager
    {
        public readonly Mapper _mapper;

        public ShopManager()
        {
            var config = new MapperConfiguration(conf => {
                conf.CreateMap<Shop, ShopDTO>();
                conf.CreateMap<Product, ProductDTO>();
                conf.CreateMap<Supplier,SupplierDTO>();
            });

            _mapper = new Mapper(config);
        }
        public IList<ShopDTO> GetShops()
        {
            using (var dbCtx = new ShopContext())
            {
                return _mapper.Map<IList<ShopDTO>>(dbCtx.Shops.ToList());
            }
        }

        //public ShopDTO GetFirstShop()
        //{
        //    using (var dbCtx = new ShopContext())
        //    {
        //        return dbCtx.Shops.First();
        //    }
        //}
    }
}
