using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    public static class Extensions
    {
        public static bool IsDivisibleBy(this int valueToCheck, int divisor)
        {
            return valueToCheck % divisor == 0;
        }
    }
}
