using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample;

namespace Tests
{
    public class CarShopTests
    {
        [Fact]
        public void GetCarsInfo_OK()
        {
            //результатом выполнения данного интерфейса является фикция
            //нужно сказать библиотеке мок, что метод в интерфейсе должен возвращать
            var mock = new Mock<ICarsStorage>();
            // указываем, какой метод будем мокить (геткарс)
            mock.Setup(carStorage => carStorage.GetCars())
                .Returns(new List<Car>
                {
                    new Car()
                    { 
                        Model = "406",
                        Maker = "Peugeot",
                        Year = 1999,
                        Price = 6000,
                        EngineCapacity = 2000
                    }
                });
            // ТАКИМ ОБРразом не используя класс карсторэйд мы получаем
            //данные юзая интерфейс и мок (

            //Act
            var carsInfo = new CarShop(mock.Object)
                .GetCarsInfo();

            //Assert
            var actualCar = carsInfo.First();
            Assert.Equal("406", actualCar.Model);
            Assert.Equal(3000, actualCar.BorderTax);
            Assert.Equal(1000, actualCar.PollutionTax);
            Assert.Equal(1200, actualCar.VatTax);
        }     
    }
}
