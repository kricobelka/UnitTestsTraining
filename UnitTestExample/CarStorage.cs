using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample
{
    //этот класс будет предоставлять машины
    public class CarStorage : ICarsStorage
    {
        public List<Car> GetCars()
        {
            return new List<Car>
            {
                new Car
                {
                    Model = "406",
                    Maker = "Peugeot",
                    Year = 1999,
                    Price = 6000,
                    EngineCapacity = 2000
                }
            };
        }
    }
}
        
