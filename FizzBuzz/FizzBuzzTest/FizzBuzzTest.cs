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

        [TestCase]
        public void When_Number_Is_Divisableby_Both_3_And_5_Returns_FizzBuzz()
        {
            int number = 15;

            Assert.AreEqual(FizzBuzzStarter.FizzBuzz(number), "FizzBuzz");
        }

        [TestCase]
        public void When_Number_Is_Not_Divisable_By_Either_Return_Number()
        {
            int number = 7;

            Assert.AreEqual(FizzBuzzStarter.FizzBuzz(number), number);
        }

    }
}