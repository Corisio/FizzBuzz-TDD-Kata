using System.Collections.Generic;

namespace FizzBuzzKata
{
    public class FizzBuzzer
    {
        public IEnumerable<string> GetStrings(int amount)
        {
            var numberFizzBuzzer = new NumberFizzBuzzer();
            var result = new List<string>();
            for (int i = 1; i <= amount; i++)
            {
                result.Add(numberFizzBuzzer.Stringify(i));        
            }
            return result;
        }
    }
}
