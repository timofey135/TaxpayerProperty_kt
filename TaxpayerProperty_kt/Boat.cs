using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxpayerProperty_kt
{
    class Boat : Vehicle
    {
        public Boat(double worth, double engineVolume) : base(worth, engineVolume) { }
        protected override string TypeName => "Лодка";
    }
}
