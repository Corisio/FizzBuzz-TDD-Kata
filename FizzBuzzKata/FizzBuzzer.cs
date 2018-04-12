using System.Collections.Generic;

namespace FizzBuzzKata
{
    public class FizzBuzzer
    {
        private readonly IIntegerProcessor _processor;

        public FizzBuzzer(IIntegerProcessor processor)
        {
            _processor = processor;
        }

        public IEnumerable<string> GetStrings(int amount)
        {
            var result = new List<string>();
            for (int i = 1; i <= amount; i++)
            {
                result.Add(_processor.Stringify(i));        
            }
            return result;
        }
    }
}
