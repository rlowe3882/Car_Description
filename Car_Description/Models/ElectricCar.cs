using System;
namespace Car_Description.Models
{
	public class ElectricCar: Car, IWarranty
	{
        public int Range { get; set; }

        public void getWarrantyInfo()
        {
            //return warranty information from DB or API
        }
    }
}

