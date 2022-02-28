using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Car_Description.ViewModels;
using Car_Description.Models;


namespace Car_Description.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ElectricCar()
        {
            ElectricCarViewModel electricCarViewModel = new ElectricCarViewModel();
            ElectricCar electricCar = electricCarViewModel.getElectricCarDetails();

            return View("ElectricCar",electricCar );

        }

        public IActionResult GasCar()
        {
            GasCarViewModel gasCarViewModel = new GasCarViewModel();
            GasCar gasCar = gasCarViewModel.getGasCarDetails();

            return View("GasCar", gasCar);
        }
    }
}