using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webproject.Data.Models;

namespace webproject.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> AllCars { get; set; }
        public string currCategory { get; set; }
    }
}
