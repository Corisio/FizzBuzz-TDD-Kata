using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata.UnitTests.Helpers
{
    class BasicIntegerProcessor : IIntegerProcessor
    {
        public string Stringify(int numberToCheck)
        {
            return numberToCheck.ToString();
        }
    }
}
