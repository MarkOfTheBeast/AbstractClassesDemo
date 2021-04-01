using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    abstract class Vehicle
    {
        public abstract int Year { get; set; }
        public abstract string Make { get; set; }
        public abstract string Model { get; set; }

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("This object did not override the DriveVirtual method.");
            Console.WriteLine();
        }

    }


}
