using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Model
{
    public class ElectricCar : ICar
    {
        public string Name { get; set; }
        public int FullChargeTimeInHours { get; set; }
        public int MilageInKms { get; set; }
        public int Milege { get; set; }
        public int Price { get; set; }

        public ElectricCar(string name, int fullChargeTimeInHours, int milageInKms, int milege, int price)
        {
            Name = name;
            FullChargeTimeInHours = fullChargeTimeInHours;
            MilageInKms = milageInKms;
            Milege = milege;
            Price = price;
        }

        public void Ship()
        {
            Console.WriteLine($"Shipping {Name} of worth {Price} of milege {Milege} and requires {FullChargeTimeInHours} hours to full charge");
        }
    }
}
