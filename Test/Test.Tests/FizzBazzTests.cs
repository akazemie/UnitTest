using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
