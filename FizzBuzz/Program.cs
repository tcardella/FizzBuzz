using System;
using System.Collections.Generic;
using System.Linq;
using FizzBuzzLibrary;

namespace FizzBuzz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var source = Enumerable.Range(1, 100);

            var rules = new Dictionary<int, string>
            {
                {3, "Fizz"},
                {5, "Buzz"}
            };

            foreach (var output in source.AsParallel().TestValues(rules))
            {
                Console.WriteLine(output);
            }
        }
    }
}