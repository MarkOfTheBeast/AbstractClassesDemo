using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Car : Vehicle
    {
        public override int Year { get; set; }
        public override string Make { get; set; }
        public override string Model { get; set; }

        public bool HasAntiLock { get; set; }

        public Car(int year, string make, string model, bool hasAntiLock)
        {
            Year = year;
            Make = make;
            Model = model;
            HasAntiLock = hasAntiLock;
        }

        public override void DriveAbstract()
        {
            Console.WriteLine($"I'm driving my {Year} {Make} {Model}.");
            Console.WriteLine(GetTrunk());
        }

        private string GetTrunk()
        {
            return HasAntiLock ? "It has antilock brakes." : "It doesn't have antilock brakes.";
        }
    }
}
