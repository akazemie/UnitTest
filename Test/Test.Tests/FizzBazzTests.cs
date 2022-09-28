using NUnit.Framework;

namespace Test.Tests
{
    [TestFixture]
    public class FizzBazzTests
    {
        private FizzBazz _fizzBazz;
        [SetUp]
        public void SetUp()
        {
            //arrange
            _fizzBazz = new FizzBazz();
        }

        [Test]
        public void GetOutPut_InputIsDividedBy3And5_ReturnFizBazz()
        {
            //act
            var result = _fizzBazz.GetOutPut(15);

            //assert
            Assert.That(result == "FizzBazz");
        }

        [Test]
        public void GetOutPut_InputIsDividedBy3_ReturnFizz()
        {
            //act
            var result = _fizzBazz.GetOutPut(3);

            //assert
            Assert.That(result == "Fizz");
        }

        [Test]
        public void GetOutPut_InputIsDividedBy5_ReturnBazz()
        {
            //act
            var result = _fizzBazz.GetOutPut(5);

            //assert
            Assert.That(result == "Bazz");
        }

        [Test]
        public void GetOutPut_InputIsNotDividedThan3Or5_ReturnSameNumber()
        {
            //act
            var result = _fizzBazz.GetOutPut(1);

            //assert
            Assert.That(result == "1");
        }
    }
}
