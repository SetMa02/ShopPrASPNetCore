using ShopPr.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPr.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> allCetegoryes { get; }
    }
}
