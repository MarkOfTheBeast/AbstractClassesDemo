using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var Car1 = new Car(2007, "Toyota", "Corolla", false);
            var Bike1 = new Motorcycle(2020, "Yamaha", "MT10", true);
            Vehicle Car2 = new Car(2021, "Mazda", "CX-5", true);
            Vehicle Bike2 = new Motorcycle(2021, "Harley", "Road King Special", false);

            var vehicles = new List<Vehicle>();

            vehicles.Add(Car1);
            vehicles.Add(Car2);
            vehicles.Add(Bike1);
            vehicles.Add(Bike2);

            foreach (Vehicle item in vehicles)
            {
                item.DriveAbstract();
                item.DriveVirtual();
            }
        }
    }
}
