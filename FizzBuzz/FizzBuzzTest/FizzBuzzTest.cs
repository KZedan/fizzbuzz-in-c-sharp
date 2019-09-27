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
            int number = 3;

            Assert.AreEqual(FizzBuzzStarter.FizzBuzz(number), "Fizz");
        }
    }
}