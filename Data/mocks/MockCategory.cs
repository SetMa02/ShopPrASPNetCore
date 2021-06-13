using ShopPr.Data.Interfaces;
using ShopPr.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopPr.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> allCetegoryes
        {
            get
            {
                return new List<Category>
                {
                    new Category{ categoryName = "Электромобиль",  desc = "экологический вид транспорта"},
                    new Category{ categoryName = "Классический автомобиль", desc = "Машина сдвигателем внутреннего сгорания"}
                }
            }
        }
       
    }
}
