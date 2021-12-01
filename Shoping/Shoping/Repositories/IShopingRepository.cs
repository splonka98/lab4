using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shoping.Models;

namespace Shoping.Repositories
{
    interface IShopingRepository
    {
        ShopingModel Get(int productId);

        IQueryable<ShopingModel> GetAllActive();

        void Add(ShopingModel product);

        void Update(int productId, ShopingModel product);
        void Delete(int productId);
    }
}
