using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webproject.Data.Models;

namespace webproject.Data.interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
