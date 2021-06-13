using ShopPr.Data.Interfaces;
using ShopPr.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopPr.Data.mocks
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory _catregoryCars = new MockCategory();

        public IEnumerable<Car> cars 
        {
            get
            {
                return new List<Car>
                {
                    new Car{name = "Tesla", 
                        shortDesc = "соврекменный электромобиль",
                        longDesc = "", 
                        img = "https://images.drive.ru/i/0/5f6c5369ec05c4fe2700000f.jpg", 
                        price = 45000,
                        isFavorite = true, 
                        availeble = true,
                        Category = _catregoryCars.allCetegoryes.First()},

                     new Car{name = "Ford Fiesta",
                        shortDesc = "удобный и тихий",
                        longDesc = "Удобный автомобилдь для городской жизни",
                        img = "https://www.masmotors.ru/colors/ford-fiesta/1.png",
                        price = 11000,
                        isFavorite = true,
                        availeble = true,
                        Category = _catregoryCars.allCetegoryes.Last()},

                       new Car{name = "BMW M3",
                        shortDesc = "Дерзкий и стильный",
                        longDesc = "Крутой автомабль на все случаи жизни",
                        img = "https://kolesa-uploads.ru/-/e292722e-bb3d-41af-8770-3cfaf1cffaa5/bmw-m3-new-front2.jpg",
                        price = 65000,
                        isFavorite = false,
                        availeble = false,
                        Category = _catregoryCars.allCetegoryes.Last()}
                };
            }
        }
        public IEnumerable<Car> getFavouriteCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
