using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ShopPr.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopPr.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if(!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value)); 
            }

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla",
                        shortDesc = "соврекменный электромобиль",
                        longDesc = "",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isFavorite = true,
                        availeble = true,
                        Category = Categories["Электромобиль"]
                    },

                     new Car
                     {
                         name = "Ford Fiesta",
                         shortDesc = "удобный и тихий",
                         longDesc = "Удобный автомобилдь для городской жизни",
                         img = "/img/Ford_Fiesta.png",
                         price = 11000,
                         isFavorite = true,
                         availeble = true,
                         Category = Categories["Классический автомобиль"]
                     },

                       new Car
                       {
                           name = "BMW M3",
                           shortDesc = "Дерзкий и стильный",
                           longDesc = "Крутой автомабль на все случаи жизни",
                           img = "/img/BMW_M3.jpg",
                           price = 65000,
                           isFavorite = false,
                           availeble = false,
                           Category = Categories["Классический автомобиль"]
                       }
                    );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category{ categoryName = "Электромобиль",  desc = "экологический вид транспорта"},
                        new Category{ categoryName = "Классический автомобиль", desc = "Машина сдвигателем внутреннего сгорания"}
                    };

                    category = new Dictionary<string, Category>();

                    foreach (Category element in list)
                        category.Add(element.categoryName, element);
                }
                return category;
            }
        }
    }
}
