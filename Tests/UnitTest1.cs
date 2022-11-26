using UnitTestExample;
namespace Tests
{
    public class TaxCalculatorTests
    {
        [Fact]
        public void Calculator_OK()
        {
            //AAA
            //1.Arrange
            var car = new Car()
            {
                Model = "406",
                Maker = "Peugeot",
                Year = 1999,
                Price = 6000,
                EngineCapacity = 2000
            };
            //Act
            var result = new TaxCalculator().Calculate(car);

            //Assert
            Assert.Equal(3000, result.BorderTax);
            Assert.Equal(1000, result.PollutionTax);
            Assert.Equal(1200, result.VatTax);

        }

        //неблагополучный тест:
        [Fact]
        public void Calculator_InvalidParameter_Fail()
        {
            Assert.Throws<ParameterInvalidException>(() => new TaxCalculator().Calculate(null));
        }
    }
}