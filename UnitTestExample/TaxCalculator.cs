using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample
{
    public class TaxCalculator
    {
        public Tax Calculate(Car car)
        {
            if(car is null)
            {
                throw new ParameterInvalidException();
            }
            return new Tax
            {
                BorderTax = GetBorderTax(car),
                PollutionTax = GetPollutionTax(car),
                VatTax = GetVatTax(car)
            };
        }

        private decimal GetBorderTax(Car car)
        {
            return 1.5m * car.EngineCapacity;
        }
        private decimal GetPollutionTax(Car car)
        {
            return 0.5m * car.EngineCapacity;
        }
        private decimal GetVatTax(Car car)
        {
            return 0.2m * car.Price;
        }

    }
}
