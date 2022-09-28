using NUnit.Framework;

namespace Test.Tests
{
    [TestFixture]
    public class FizzBazzTests
    {

        [Test]
        public void GetOutPut_InputIsDividedBy3And5_ReturnFizBazz()
        {
            //arrange
            var fizBazz = new FizzBazz();

            //act
            var result = fizBazz.GetOutPut(15);

            //assert
            Assert.That(result == "FizzBazz");
        }

        [Test]
        public void GetOutPut_InputIsDividedBy3_ReturnFizz()
        {
            //arrange
            var fizBazz = new FizzBazz();

            //act
            var result = fizBazz.GetOutPut(3);

            //assert
            Assert.That(result == "Fizz");
        }

        [Test]
        public void GetOutPut_InputIsDividedBy5_ReturnBazz()
        {
            //arrange
            var fizBazz = new FizzBazz();

            //act
            var result = fizBazz.GetOutPut(5);

            //assert
            Assert.That(result == "Bazz");
        }

        [Test]
        public void GetOutPut_InputIsNotDividedThan3Or5_ReturnSameNumber()
        {
            //arrange
            var fizBazz = new FizzBazz();

            //act
            var result = fizBazz.GetOutPut(1);

            //assert
            Assert.That(result == "1");
        }
    }
}
