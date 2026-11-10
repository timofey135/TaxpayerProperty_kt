using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxpayerProperty_kt
{
    class CountryHouse : Immovable
    {
        public CountryHouse(double worth, double area) : base(worth, area) { }
        protected override string TypeName => "Дача";
    }
}
