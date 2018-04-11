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

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(8)]
        [TestCase(9)]
        [TestCase(10)]
        [TestCase(15)]
        [TestCase(20)]
        public void ReturnFizzOrBuzzOrFizzBuzzOrTheOrdinalOfTheElementAsString(int value)
        {
            IList<string> response = new List<string>(fizzBuzzer.GetStrings(value));
            for (int i = 0; i < value; i++)
            {
                var acceptableValues = new List<string>() { "Fizz", "Buzz", "FizzBuzz", (i + 1).ToString() };
                Assert.IsTrue(acceptableValues.Contains(response[i]));
            }

        }
    }
}
