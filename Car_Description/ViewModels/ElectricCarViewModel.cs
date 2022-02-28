using System;
using Car_Description.Models;

namespace Car_Description.ViewModels
{
	public class ElectricCarViewModel
	{
		public ElectricCar getElectricCarDetails()
        {
			var electricCar = new ElectricCar();

			electricCar.Color = "Red";
			electricCar.Make = "Tesla";
			electricCar.Model = "Model 3";
			electricCar.NumberOfDoors = 4;
			electricCar.Year = "2022";
			electricCar.Range = 358;
			electricCar.ImageUrl = "https://images.unsplash.com/photo-1538592116845-119a3974c958?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1332&q=80";


			electricCar.Engine = new Engine { FuelType = FuelType.Battery };


			return electricCar;

		
              
        }
	}
}

