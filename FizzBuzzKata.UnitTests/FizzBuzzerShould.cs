using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzzKata.UnitTests
{
    [TestFixture]
    public class FizzBuzzerShould
    {
        private static FizzBuzzer fizzBuzzer;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            fizzBuzzer = new FizzBuzzer();
        }

        [TestCase(-1)]
        [TestCase(0)]
        public void ReturnAnEmptySetOfStrings_WhenTheNumberOfElementsRequestedIsNotPositive(int amount)
        {
            IEnumerable<string> response = fizzBuzzer.GetStrings(amount);
            Assert.IsNotNull(response);
            Assert.IsEmpty(response);
        }

        [TestCase(1)]
        [TestCase(2)]
        public void ReturnTheRequestedNumberOfStrings(int expectedSize)
        {
            IEnumerable<string> response = fizzBuzzer.GetStrings(expectedSize);
            Assert.IsNotNull(response);
            Assert.IsNotEmpty(response);
            Assert.AreEqual(expectedSize, response.Count());
        }
    }
}
