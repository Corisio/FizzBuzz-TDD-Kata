using NUnit.Framework;

namespace FizzBuzzKata.UnitTests
{
    [TestFixture]
    public class NumberFizzBuzzerShould
    {
        private const string FIZZ = "Fizz";
        private const string BUZZ = "Buzz";

        private static NumberFizzBuzzer numberFizzBuzzer;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            numberFizzBuzzer = new NumberFizzBuzzer();
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void FizzWhenTheValueIsDivisibleOnlyByThree(int value)
        {
            var response = numberFizzBuzzer.Stringify(value);
            Assert.AreEqual(FIZZ, response);
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void BuzzWhenTheValueIsDivisibleOnlyByFive(int value)
        {
            var response = numberFizzBuzzer.Stringify(value);
            Assert.AreEqual(BUZZ, response);
        }

        [TestCase(1)]
        [TestCase(4)]
        [TestCase(8)]
        public void ReturnNumberWhenNotDivisibleByThreeOrFive(int value)
        {
            var response = numberFizzBuzzer.Stringify(value);
            Assert.AreEqual(value.ToString(), response);
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void FizzBuzzWhenTheValueIsDivisibleByThreeAndFive(int value)
        {
            var response = numberFizzBuzzer.Stringify(value);
            Assert.AreEqual(FIZZ + BUZZ, response);
        }

    }
}
