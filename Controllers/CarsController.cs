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
    public class CarsController: Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategoryes;

         public CarsController(IAllCars iAllCars, ICarsCategory iCarsCategory)
        {
            _allCars = iAllCars;
            _allCategoryes = iCarsCategory;
        }

        public ViewResult List()
        {
            ViewBag.Ttile = "Страница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currentCategory = "автомобили";
            return View(obj);
        }
    }
}
