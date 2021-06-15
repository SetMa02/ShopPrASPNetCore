using Microsoft.AspNetCore.Mvc;
using ShopPr.Data.Interfaces;
using ShopPr.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopPr.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllCars _carRepository;
   
        public HomeController(IAllCars carRepository)
        {
            _carRepository = carRepository;
        }
        public ViewResult Index()
        {
            HomeViewModel homeCars = new HomeViewModel 
            {
                favCars = _carRepository.getFavouriteCars
            };
            return View(homeCars);
        }
    }
}
