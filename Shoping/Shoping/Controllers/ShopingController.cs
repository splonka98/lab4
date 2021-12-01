using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shoping.Models;
using Shoping.Repositories;

namespace Shoping.Controllers
{
    public class ShopingController : Controller
    {
        //private static IList<ShopingModel> products = new List<ShopingModel>()
        // {
        //  new ShopingModel(){ProductId = 1, Name = "Chleb", Description = "słonecznikowy/razowy", Quantity = 1, Bought = false },
        //  new ShopingModel(){ProductId = 2, Name = "Jabłko", Description = "Jakieś duże szampiony", Quantity = 5, Bought = false },
        //  new ShopingModel(){ProductId = 3, Name = "Marchew", Description = "Średnie", Quantity = 3, Bought = false },
        // new ShopingModel(){ProductId = 4, Name = "Maslo", Description = "Na promocji <6zł", Quantity = 1, Bought = false },
        //};
        private readonly IShopingRepository _shopingRepository;

        public ShopingController(IShopingRepository shopingRepository)
        {
            _shopingRepository = shopingRepository;
        }
                




        // GET: Shoping
        public ActionResult Index()
        {
            return View(_shopingRepository.GetAllActive());
        }

        // GET: Shoping/Details/5
        public ActionResult Details(int id)
        {
            return View(_shopingRepository.Get(id));
        }

        // GET: ShopingController/Create
        public ActionResult Create()
        {
            return View(new ShopingModel());
        }

        // POST: Shoping/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ShopingModel shopingModel)
        {

            _shopingRepository.Add(shopingModel);
            return RedirectToAction(nameof(Index));
            
        }

        // GET: Shoping/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_shopingRepository.Get(id));
        }

        // POST: Shoping/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ShopingModel shopingModel)
        {
            _shopingRepository.Update(id, shopingModel);
            return RedirectToAction(nameof(Index));
            
        }

        // GET: Shoping/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_shopingRepository.Get(id));
        }

        // POST: Shoping/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _shopingRepository.Delete(id);
            return RedirectToAction(nameof(Index));
            
        }
        //GET:Shoping/Done/5
        public ActionResult Bought (int id)
        {
            ShopingModel product = _shopingRepository.Get(id);
            product.Bought = true;
            _shopingRepository.Update(id, product);

            return RedirectToAction(nameof(Index));
        }
    }
}
