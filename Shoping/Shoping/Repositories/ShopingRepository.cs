using Shoping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoping.Repositories
{
    public class ShopingRepository : IShopingRepository
    {
        private readonly ShopingContext _context;
        public ShopingRepository(ShopingContext context)
        {
            _context = context;
        }
        public ShopingModel Get(int productId)
            => _context.Products.SingleOrDefault(x => x.ProductId == productId);

        private object GetShoping()
        {
            return _context.Shoping;
        }

        public IQueryable<ShopingModel> GetAllActive()
            => _context.Products.Where(x => !x.Bought);
        public void Add(ShopingModel product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
                

        public void Update(int productId, ShopingModel product)
        {
            var result = _context.Products.SingleOrDefault(x => x.ProductId == productId);
            if(result!=null)
            {
                result.Name = product.Name;
                result.Description = product.Description;
                result.Bought = product.Bought;

                _context.SaveChanges();
            }

        }

        public void Delete(int productId)
        {
            var result = _context.Products.SingleOrDefault(x => x.ProductId == productId);
            if(result!=null)
            {
                _context.Products.Remove(result);
                _context.SaveChanges();
            }
        }




    }
}
