using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace FizzBuzzKata.UnitTests
{
    [TestFixture]
    public class FizzBuzzerShould
    {
        [TestCase(-1)]
        [TestCase(0)]
        public void ReturnAnEmptySetOfStrings_WhenTheNumberOfElementsRequestedIsNotPositive(int amount)
        {
            var fizzBuzzer = new FizzBuzzer();

            IEnumerable<string> response = fizzBuzzer.GetStrings(amount);
            Assert.IsNotNull(response);
            Assert.IsEmpty(response);
        }

        [TestCase(1)]
        [TestCase(2)]
        public void ReturnTheRequestedNumberOfStrings(int expectedSize)
        {
            var fizzBuzzer = new FizzBuzzer();

            IEnumerable<string> response = fizzBuzzer.GetStrings(expectedSize);
            Assert.IsNotNull(response);
            Assert.IsNotEmpty(response);
            Assert.AreEqual(expectedSize, response.Count());
        }
    }
}
