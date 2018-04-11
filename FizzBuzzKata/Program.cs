using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FizzBuzzer fizzBuzzer = new FizzBuzzer();

            foreach (var stringifiedValue in fizzBuzzer.GetStrings(20))
            {
                Console.WriteLine(stringifiedValue);
            }
        }
    }
}
