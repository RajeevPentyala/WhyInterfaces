using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper.Model;

namespace WhyInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = GetCars();

            foreach (var car in cars)
            {
                car.Ship();
            }

            Console.ReadLine();
        }

        public static List<ICar> GetCars()
        {
            var cars = new List<ICar>
            {
                new ElectricCar("Tesla", 4, 100,20,20000),
                new GasCar("BMW", 60, 1000,18,10000)
            };

            return cars;
        }
    }
}
