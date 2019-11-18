using System;
using System.Collections.Generic;

namespace ClassListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carLot = new List<Car>();

            Car ford = new Car("Ford", "Bronco", 80_000);
            ford.Year = 1986;
            ford.isInspected = true;
            ford.CountryOfOrigin = "USA";
            ford.Color = "Pearl";

            Car toyota = new Car("Toyota", "4Runner", 300)
            {
                Year = 2019,
                Color = "white",
                isInspected = false,
                CountryOfOrigin = "Japan"
            };

            Car chevy = new Car("Chevy", "Malibu", 200_000)
            {
                Year = 1995,
                Color = "Pink",
                isInspected = false,
                CountryOfOrigin = "USA"
            };

            carLot.Add(ford);
            carLot.Add(toyota);
            carLot.Add(chevy);

            Console.WriteLine($"The ford has {ford.Mileage} on it.");
            ford.Drive(10);
            Console.WriteLine($"The ford has now driven {ford.Mileage} miles.");
            Console.WriteLine(toyota.Description);
            ford.Drive(3_269);
            toyota.Drive(352);
            chevy.Drive(69);
            Console.WriteLine(ford.Description);
            Console.WriteLine(chevy.Description);
            ford.Drive();
            Console.WriteLine($"it now had {ford.Mileage}");
        }
    }
}