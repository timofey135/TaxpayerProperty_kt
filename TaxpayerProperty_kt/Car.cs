using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxpayerProperty_kt
{
    class Car : Vehicle
    {
        public Car(double worth, double engineVolume) : base(worth, engineVolume) { }
        protected override string TypeName => "Машина";
    }
}
