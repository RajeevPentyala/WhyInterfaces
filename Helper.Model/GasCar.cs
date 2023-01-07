using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Model
{
    public class GasCar : ICar
    {
        public string Name { get; set; }
        public int CapacityInLiters { get; set; }
        public int MilageInKms { get; set; }
        public int Milege { get; set; }
        public int Price { get; set; }

        public GasCar(string name, int capacityInLiters, int milageInKms, int milege, int price)
        {
            Name = name;
            CapacityInLiters = capacityInLiters;
            MilageInKms = milageInKms;
            Milege = milege;
            Price = price;
        }

        public void Ship()
        {
            Console.WriteLine($"Shipping {Name} of worth {Price} of milege {Milege} and requires {CapacityInLiters} liters to full tank");
        }
    }
}
