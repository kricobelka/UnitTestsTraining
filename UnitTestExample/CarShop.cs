using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample.Dtos;

namespace UnitTestExample
{
    //будет выдавать dto (будет расширенная модель с таксами)
    public class CarShop
    {
        private readonly ICarsStorage _carsStorage;

        public CarShop(ICarsStorage carsStorage)
        {
            _carsStorage = carsStorage;
        }

        public List<CarDto> GetCarsInfo()
        {
            var taxCalculator = new TaxCalculator();
            var cars = _carsStorage.GetCars();


            return cars.Select(q =>
            {
                var taxes = taxCalculator.Calculate(q);
                var car = new CarDto
                {
                    Model = q.Model,
                    BorderTax = taxes.BorderTax,
                    PollutionTax = taxes.PollutionTax,
                    VatTax = taxes.VatTax
                };
                return car;
            }).ToList();
        }
    }
}
    