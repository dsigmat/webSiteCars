using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webproject.Data.interfaces;
using webproject.Data.Models;

namespace webproject.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        name = "TESLA",
                        shortDesc = "",
                        longDesc = "",
                        img = "https://pol-z.ru/wp-content/uploads/2015/02/291.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                     new Car
                    {
                        name = "Mercedes-Benz",
                        shortDesc = "",
                        longDesc = "",
                        img = "https://avatars.mds.yandex.net/get-pdb/398891/87bfaf4c-e0ce-4ac9-8708-ff5aea1f30aa/s1200",
                        price = 95000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                      new Car
                    {
                        name = "BMW",
                        shortDesc = "",
                        longDesc = "",
                        img = "https://avatars.mds.yandex.net/get-pdb/1664921/ac90bc84-f05e-4dd5-b639-fa0c5e8b45fa/s1200?webp=false",
                        price = 55000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                       new Car
                    {
                        name = "AUDI",
                        shortDesc = "",
                        longDesc = "",
                        img = "https://avatars.mds.yandex.net/get-pdb/931085/8a2d1469-433d-4422-b9eb-cd3301bbb123/s1200?webp=false",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
