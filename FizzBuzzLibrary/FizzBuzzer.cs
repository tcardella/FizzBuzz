using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzLibrary
{
    /// <summary>
    /// Fizz/Buzz extension methods
    /// </summary>
    public static class FizzBuzzer
    {
        /// <summary>
        /// Performs a "Fizz/Buzz" test against a sequence of integers using the given rules.
        /// </summary>
        /// <param name="inputValues">Sequence of integers to be tested.</param>
        /// <param name="rules">Rules to be applied to the input values.</param>
        /// <returns>Returns a sequence of strings with the results of the "Fizz/Buzz" test.</returns>
        public static IEnumerable<string> TestValues(this IEnumerable<int> inputValues, Dictionary<int, string> rules)
        {
            foreach (var inputValue in inputValues)
            {
                if (rules == null)
                {
                    yield return inputValue.ToString();
                }
                else
                {
                    var matches = rules.Keys
                        .Where(key => inputValue%key == 0)
                        .Select(key => rules[key])
                        .ToArray();

                    yield return matches.Any()
                        ? string.Join(" ", matches)
                        : inputValue.ToString();
                }
            }
        }
    }
}