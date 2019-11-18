using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webproject.Data.interfaces;
using webproject.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webproject.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategory;
        public CarsController(IAllCars allCar, ICarsCategory allCategory)
        {
            _allCars = allCar;
            _allCategory = allCategory;
        }
        // GET: /<controller>/
        public IActionResult List()
        {
            //var cars = _allCars.Cars;
            //ViewBag.Category = "Все автомобили";
            ViewBag.Title = "Страница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.AllCars = _allCars.Cars;
            obj.currCategory = "Автомобили";
            return View(obj);
        }
    }
}
