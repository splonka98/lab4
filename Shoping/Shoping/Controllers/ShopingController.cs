using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shoping.Models;

namespace Shoping.Controllers
{
    public class ShopingController : Controller
    {
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
        }

        // GET: ShopingController/Create
        public ActionResult Create()
        {
            return View(new ShopingModel());
        }

        // POST: ShopingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ShopingModel shopingModel)
        {
            shopingModel.ProductId = products.Count + 1;
            products.Add(shopingModel);     
            return RedirectToAction(nameof(Index));
            
        }

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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
