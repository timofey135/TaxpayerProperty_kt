using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxpayerProperty_kt
{
    class Apartment : Immovable
    {
        public Apartment(double worth, double area) : base(worth, area) { }

        protected override string TypeName => "Квартира";
    }
}
