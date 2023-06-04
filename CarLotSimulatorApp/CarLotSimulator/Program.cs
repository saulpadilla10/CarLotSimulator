using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

           

            var firstCar = new Car();
            firstCar.Make = "Kia";
            firstCar.Model = "Sephia";
            firstCar.Year = 2003;
            firstCar.EngineNoise = "Pooooooop";
            firstCar.HonkNoise = "Wah-Wah!";
            firstCar.IsDriveable = false;

            Console.WriteLine($"{firstCar.Make} {firstCar.Model} {firstCar.Year} {firstCar.EngineNoise} {firstCar.HonkNoise} {firstCar.IsDriveable}");

            Console.WriteLine();

            var secondCar = new Car()
            {
                Make = "Hyundai",
                Model = "Tiburon GT",
                Year = 2008,
                EngineNoise = "Vroooooom!",
                HonkNoise = "Veeeeep!",
                IsDriveable = true
            };

            Console.WriteLine($"{secondCar.Make} {secondCar.Model} {secondCar.Year} {secondCar.EngineNoise} {secondCar.HonkNoise} {secondCar.IsDriveable}");

            Console.WriteLine();

            var thirdCar = new Car("Jeep", "Compass", 2008, "Zzzz", "Heeeee!", true);

            Console.WriteLine($"{thirdCar.Make} {thirdCar.Model} {thirdCar.Year} {thirdCar.EngineNoise} {thirdCar.HonkNoise} {thirdCar.IsDriveable}");

            Console.WriteLine();

            firstCar.MakeEngineNoise(firstCar.EngineNoise);

            firstCar.MakeHonkNoise(firstCar.HonkNoise);

            Console.WriteLine();

            secondCar.MakeEngineNoise(secondCar.EngineNoise);

            secondCar.MakeHonkNoise(secondCar.HonkNoise);

            Console.WriteLine();

            thirdCar.MakeEngineNoise(thirdCar.EngineNoise);

            thirdCar.MakeHonkNoise(thirdCar.HonkNoise);

            Console.WriteLine();

            var list = new CarLot();

            list.Carlist.Add(firstCar);

            list.Carlist.Add(secondCar);

            list.Carlist.Add(thirdCar);

            foreach (var car in list.Carlist)
            {
                Console.WriteLine($"Make: {car.Make}. Model: {car.Model}. Year: {car.Year}. Goes: {car.EngineNoise}. Honker: {car.HonkNoise}. Works? {car.IsDriveable}.");
            }
        }
    }
}