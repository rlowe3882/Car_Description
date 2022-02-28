using System;
namespace Car_Description.Models
{
	public abstract class Car 
	{
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public int NumberOfDoors { get; set; }
        public string ImageUrl { get; set; }
        public Engine Engine { get; set; }
        
    }
}

