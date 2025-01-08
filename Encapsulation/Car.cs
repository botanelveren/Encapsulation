using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        private int _numberOfDoors;
        public int NumberOfDoors
        {
            get
            {
                return _numberOfDoors;
            }

            set
            {
                if (value == 2 || value == 4)
                {
                    _numberOfDoors = value;
                }
                else
                {
                    Console.WriteLine("Kapı sayısı 2 veya 4 olabilir.");
                    _numberOfDoors = -1;
                }
            }
        }

        public Car(string brand, string model, string color, int numberOfDoors)
        {
            Brand = brand;
            Model = model;
            Color = color;
            NumberOfDoors = numberOfDoors;
        }
    }
}
