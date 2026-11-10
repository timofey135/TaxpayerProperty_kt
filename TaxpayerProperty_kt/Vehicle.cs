using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxpayerProperty;

namespace TaxpayerProperty_kt
{
    abstract class Vehicle : Property
    {
        protected double engineVolume; 

        public Vehicle(double worth, double engineVolume) : base(worth)
        {
            this.engineVolume = engineVolume;
        }

        public override double CalculateTax()
        {
            return worth * engineVolume / 3000.0;
        }

        public override string ToString()
        {
            return $"{TypeName}: Стоимость - {worth:0.##}, налог - {CalculateTax():0.##}, объём двигателя - {engineVolume:0.##} см.куб";
        }
    }
}
