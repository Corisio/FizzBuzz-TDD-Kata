using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace FizzBuzzKata.UnitTests
{
    [TestFixture]
    public class FizzBuzzerShould
    {
        [Test]
        public void ReturnAnEmptySetOfStrings_WhenTheNumberOfElementsRequestedIsLowerThanZero()
        {
            var fizzBuzzer = new FizzBuzzer();

            IEnumerable<string> response = fizzBuzzer.GetStrings(-1);
            Assert.IsNotNull(response);
            Assert.IsEmpty(response);
        }
    }
}
