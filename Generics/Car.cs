using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Car
    {
        public string Model { get; set; }
        public FuelLevel Fuel { get; private set; } = FuelLevel.Empty;

        public Car(string model)
        {
            Model = model;
        }
        public void Refuel()
        {
            Fuel = FuelLevel.Full;
            Console.WriteLine($"{Model} has been refueled to full.");
        }

        public void Drive()
        {
            if (Fuel == FuelLevel.Empty)
            {
                Console.WriteLine($"{Model} cannot drive because it has no fuel..");
            }
            else
            {
                Console.WriteLine($"{Model} is going for a drive!");
                Fuel = FuelLevel.Empty;  // Assume fuel is used up after one drive.

            }
        }
    }
}
