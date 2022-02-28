using System;
using Car_Description.Models;

namespace Car_Description.ViewModels
{
	public class GasCarViewModel
	{
		public GasCar getGasCarDetails()
        {
			var gasCar = new GasCar();

			gasCar.Color = "White";
			gasCar.CityMPG = 21;
			gasCar.HwyMPG = 30;
			gasCar.NumberOfDoors = 2;
			gasCar.Make = "Ford";
			gasCar.Model = "Mustang";
			gasCar.ImageUrl = "https://images.unsplash.com/photo-1612544448445-b8232cff3b6c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1074&q=80";
			gasCar.Engine = new Engine { FuelType = FuelType.Gas };

			gasCar.getWarrantyInfo();

			return gasCar;

			
        }
	}
}

