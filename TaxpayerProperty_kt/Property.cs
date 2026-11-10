using System;

namespace TaxpayerProperty
{
    abstract class Property
    {
        protected double worth; 

        public Property(double worth)
        {
            this.worth = worth;
        }

        public abstract double CalculateTax();

        protected abstract string TypeName { get; }
    }
}