using System.Collections.Generic;
using System.Linq;
using FizzBuzzLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzLibraryTests
{
    [TestClass]
    public class FizzBuzzerTests
    {
        [TestMethod, TestCategory("FizzBuzzerTests")]
        public void WhenDivisibleBy3ReturnFizz()
        {
            var source = new[] {3, 6, 9};
            var rules = new Dictionary<int, string> {{3, "Fizz"}};

            var actual = source.TestValues(rules).ToArray();

            Assert.IsTrue(actual.All(e => e == "Fizz"));
        }

        [TestMethod, TestCategory("FizzBuzzerTests")]
        public void WhenDivisibleBy5ReturnBuzz()
        {
            var source = new[] {5, 10, 20};
            var rules = new Dictionary<int, string> {{5, "Buzz"}};

            var actual = source.TestValues(rules).ToArray();

            Assert.IsTrue(actual.All(e => e == "Buzz"));
        }

        [TestMethod, TestCategory("FizzBuzzerTests")]
        public void WhenDivisibleBy5And3ReturnFizz_Buzz()
        {
            var source = new[] {15, 30, 90};
            var rules = new Dictionary<int, string> {{3, "Fizz"}, {5, "Buzz"}};

            var actual = source.TestValues(rules).ToArray();

            Assert.IsTrue(actual.All(e => e == "Fizz Buzz"));
        }

        [TestMethod, TestCategory("FizzBuzzerTests")]
        public void WhenNotDivisibleBy3Or5ReturnNumber()
        {
            var source = new[] {4, 7, 11};
            var rules = new Dictionary<int, string>();

            var actual = source.TestValues(rules).ToArray();

            Assert.AreEqual("4", actual[0]);
            Assert.AreEqual("7", actual[1]);
            Assert.AreEqual("11", actual[2]);
        }

        [TestMethod, TestCategory("FizzBuzzerTests")]
        public void WhenRulesIsNullReturnNumbersOnly()
        {
            var source = Enumerable.Range(1, 3).ToArray();
            Dictionary<int, string> rules = null;

            var actual = source.TestValues(rules).ToArray();

            Assert.AreEqual("1", actual[0]);
            Assert.AreEqual("2", actual[1]);
            Assert.AreEqual("3", actual[2]);
        }

        [TestMethod, TestCategory("FizzBuzzerTests")]
        public void WhenRulesIsEmptyReturnNumbersOnly()
        {
            var source = Enumerable.Range(1, 3).ToArray();
            var rules = new Dictionary<int, string>();

            var actual = source.TestValues(rules).ToArray();

            Assert.AreEqual("1", actual[0]);
            Assert.AreEqual("2", actual[1]);
            Assert.AreEqual("3", actual[2]);
        }
    }
}