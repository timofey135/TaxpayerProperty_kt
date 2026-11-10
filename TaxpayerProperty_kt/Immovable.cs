using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxpayerProperty;

namespace TaxpayerProperty_kt
{
    abstract class Immovable : Property
    {
        protected double area; 
        public Immovable(double worth, double area) : base(worth)
        {
            this.area = area;
        }

        public override double CalculateTax()
        {
            if (area < 100)
                return worth / 500.0;
            else if (area <= 300)
                return worth / 350.0;
            else
                return worth / 250.0;
        }

        public double GetPricePerSquareMeter()
        {
            return worth / area;
        }

        public override string ToString()
        {
            return $"{TypeName}: Стоимость - {worth:0.##}, налог - {CalculateTax():0.##}, площадь - {area:0.##} кв.м";
        }
    }
}
