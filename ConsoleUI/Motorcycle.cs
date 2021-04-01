using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
        public override int Year { get; set; }
        public override string Make { get; set; }
        public override string Model { get; set; }

        public bool HasSideCar { get; set; }

        public Motorcycle(int year, string make, string model, bool hasSideCar)
        {
            Year = year;
            Make = make;
            Model = model;
            HasSideCar = hasSideCar;
        }
        public override void DriveAbstract()
        {
            Console.WriteLine($"I'm driving my {Year} {Make} {Model}.");
            Console.WriteLine(GetSideCar());

        }

        public override void DriveVirtual()
        {
            Console.WriteLine( (HasSideCar) ? "I would do a wheelie but not with a sidecar attached" : "I do wheelies on the road. Don't tell the cops.");
            Console.WriteLine();
        }

        private string GetSideCar()
        {
            return HasSideCar ? "It has a sidecar." : "It doesn't have a sidecar.";
        }
    }
}
