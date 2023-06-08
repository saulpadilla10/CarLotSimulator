using System;
using System.Collections.Generic;
namespace CarLotSimulator
{
	public class CarLot
	{
		public CarLot()
		{

		}


		public List<Car> Carlist = new List<Car>();

		public static int numberOfCars = 1;

        public static int NumberOfCars
        {
            get { return numberOfCars; }
        }



    }
}

