using System;
namespace Car_Description.Models
{
	public class GasCar : Car, IWarranty
	{
		public int CityMPG { get; set; }
		public int HwyMPG { get; set; }

		public void getWarrantyInfo()
		{
			//return warranty information from DB or API
		}
	}
}

