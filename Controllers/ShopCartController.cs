using Microsoft.AspNetCore.Mvc;
using ShopPr.Data.Interfaces;
using ShopPr.Data.Models;
using ShopPr.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopPr.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllCars carRepository;
        private readonly ShopCart shopCart;

        public ShopCartController(IAllCars carRepository, ShopCart shopCart)
        {
            this.carRepository = carRepository;
            this.shopCart = shopCart; 

        }

        public ViewResult Index()
        {
            var items = shopCart.getShopItems();
            shopCart.listShopItems = items;

            ShopCartViewModel obj = new ShopCartViewModel
            {
                shopCart = shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id )
        {
            var item = carRepository.Cars.FirstOrDefault(c => c.id == id);
            if (item != null)
            {
                shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
        
    }
}
