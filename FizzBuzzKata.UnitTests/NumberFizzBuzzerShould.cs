using NUnit.Framework;
using NUnit.Framework.Internal;

namespace FizzBuzzKata.UnitTests
{
    [TestFixture]
    public class NumberFizzBuzzerShould
    {
        [Test]
        public void FizzWhenTheValueIsDivisibleByThree ()
        {
            var numberFizzBuzzer = new NumberFizzBuzzer();

            var response = numberFizzBuzzer.Stringify(3);
            Assert.AreEqual("Fizz", response);
        }
    }
}
