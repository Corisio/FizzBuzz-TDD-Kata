using System.Text;

namespace FizzBuzzKata
{
    public class NumberFizzBuzzer
    {
        public string Stringify(int numberToCheck)
        {
            var builder = new StringBuilder();

            if (numberToCheck.IsDivisibleBy(3))
            {
                builder.Append("Fizz");
            }

            if (numberToCheck.IsDivisibleBy(5))
            {
                builder.Append("Buzz");
            }

            if (builder.Length == 0)
            {
                builder.Append(numberToCheck.ToString());
            }

            return builder.ToString();

        }
    }
}
