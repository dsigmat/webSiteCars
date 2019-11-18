using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webproject.Data.Models;

namespace webproject.Data.interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> getFavCars { get; set; }
        Car getObjectCar(int carId);
    }
}
