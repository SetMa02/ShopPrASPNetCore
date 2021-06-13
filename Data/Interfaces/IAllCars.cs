using ShopPr.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPr.Data.Interfaces
{
    interface IAllCars
    {
        IEnumerable<Car> cars { get; set; }
        IEnumerable<Car> getFavouriteCars { get; set; }
        Car getObjectCar(int carId);
    }
}
