using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    public class FizzBuzzer
    {
        public IEnumerable<string> GetStrings(int amount)
        {
            var result = new List<string>();
            for (int i = 0; i < amount; i++)
            {
                result.Add(null);        
            }
            return result;
        }
    }
}
