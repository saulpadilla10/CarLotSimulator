using System;
namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;

        }
        public Car(string make, string model, int year, string enginenoise, string honknoise, bool isdrivable)
        {
            Make = make;
            Model = model;
            Year = year;
            EngineNoise = enginenoise;
            HonkNoise = honknoise;
            IsDriveable = isdrivable;

        }
        

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }
        

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(engineNoise);
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }


    }
}

