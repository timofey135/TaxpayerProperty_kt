using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxpayerProperty;

namespace TaxpayerProperty_kt
{
    class Program
    {
        static void Main(string[] args)
        {
            Property[] properties = new Property[10];

            properties[0] = new Apartment(3000000, 45);
            properties[1] = new Apartment(5000000, 85);
            properties[2] = new Apartment(8000000, 120);

            properties[3] = new Car(1500000, 1600);
            properties[4] = new Car(2500000, 2000);
            properties[5] = new Car(900000, 1400);

            properties[6] = new Boat(400000, 1500);
            properties[7] = new Boat(1200000, 3000);

            properties[8] = new CountryHouse(5000000, 350);
            properties[9] = new CountryHouse(2000000, 90);

            Console.WriteLine("--- Имущество налогоплательщиков ---\n");
            foreach (Property prop in properties)
            {
                Console.WriteLine(prop.ToString());
            }
        }
    }
}
