using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shoping.Models;
<<<<<<< HEAD
using Shoping.Repositories;
=======
>>>>>>> 8dbd5308708360f24b0600f82a4b4ff28512741b

namespace Shoping.Controllers
{
    public class ShopingController : Controller
    {
<<<<<<< HEAD
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
=======
        private static IList<ShopingModel> products = new List<ShopingModel>()
        {
            new ShopingModel(){ProductId = 1, Name = "Chleb", Description = "słonecznikowy/razowy", Quantity = 1, Bought = false },
            new ShopingModel(){ProductId = 2, Name = "Jabłko", Description = "Jakieś duże szampiony", Quantity = 5, Bought = false },
            new ShopingModel(){ProductId = 3, Name = "Marchew", Description = "Średnie", Quantity = 3, Bought = false },
            new ShopingModel(){ProductId = 4, Name = "Maslo", Description = "Na promocji <6zł", Quantity = 1, Bought = false },
        };
        // GET: ShopingController
        public ActionResult Index()
        {
            return View(products);
        }

        // GET: ShopingController/Details/5
        public ActionResult Details(int id)
        {
            return View();
>>>>>>> 8dbd5308708360f24b0600f82a4b4ff28512741b
        }

        // GET: ShopingController/Create
        public ActionResult Create()
        {
            return View(new ShopingModel());
        }

<<<<<<< HEAD
        // POST: Shoping/Create
=======
        // POST: ShopingController/Create
>>>>>>> 8dbd5308708360f24b0600f82a4b4ff28512741b
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ShopingModel shopingModel)
        {
<<<<<<< HEAD

            _shopingRepository.Add(shopingModel);
=======
            shopingModel.ProductId = products.Count + 1;
            products.Add(shopingModel);     
>>>>>>> 8dbd5308708360f24b0600f82a4b4ff28512741b
            return RedirectToAction(nameof(Index));
            
        }

<<<<<<< HEAD
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
=======
        // GET: ShopingController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShopingController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShopingController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShopingController/Delete/5
>>>>>>> 8dbd5308708360f24b0600f82a4b4ff28512741b
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
<<<<<<< HEAD
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
=======
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
>>>>>>> 8dbd5308708360f24b0600f82a4b4ff28512741b
        }
    }
}
