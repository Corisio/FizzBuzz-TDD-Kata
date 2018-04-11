namespace FizzBuzzKata
{
    public class NumberFizzBuzzer
    {
        public string Stringify(int numberToCheck)
        {
            if (numberToCheck % 3 == 0)
            {
                return "Fizz";
            }

            if (numberToCheck % 5 == 0)
            {
                return "Buzz";
            }

            return numberToCheck.ToString();
        }
    }
}
