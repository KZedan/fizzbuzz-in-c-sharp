using FizzBuzz;
using NUnit.Framework;

namespace FizzBuzzTest
{
    [TestFixture]
    public class Tests
    {

        [TestCase]
        public void When_Number_Is_Divisable_By_3_Returns_Fizz()
        {    
            int number = 6;

            Assert.AreEqual(FizzBuzzStarter.FizzBuzz(number), "Fizz");
        }

        [TestCase]
        public void When_Number_Is_Divisable_By_5_Returns_Buzz()
        {
            int number = 10;

            Assert.AreEqual(FizzBuzzStarter.FizzBuzz(number), "Buzz");
        }

    }
}