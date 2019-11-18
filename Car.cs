using System;

namespace ClassListDemo
{

    class Car
    {

        // Fields are similar to properties but they are typically private
        // and dont specify getters and setters
        private string _vinNumber;

        // Constructor 
        public Car(string make, string model, int mileage)
        {
            Make = make;
            Model = model;
            Mileage = mileage;

            Random rand = new Random();
            {
                _vinNumber = rand.Next(11_111_111, 99_999_999).ToString();
            }
        }

        private int _standardTestDrive = 5;
        public string Make { get; set; }
        public int Mileage { get; private set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string CountryOfOrigin { get; set; }
        public bool isInspected { get; set; }

        public string Description
        {
            get
            {
                return $"{Year} {Make} {Model} with {Mileage} miles.";
            }
        }

        public void Drive(int milesDriven)
        {
            Mileage += milesDriven;
        }
        public void Drive()
        {
            Mileage += _standardTestDrive;
        }

        public string Honk()
        {
            return "HONKKKKK!!!!!!";
        }
    }
}