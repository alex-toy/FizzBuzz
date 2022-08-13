using FizzBuzz;
using NUnit.Framework;

namespace FizzBuzzTests
{
    [TestFixture]
    public class FizzBuzztests
    {
        [TestCase(1, "1")]
        public static void should_return_output_when_input_is_given(int input, string expected)
        {
            string actual = FizzBuzzer.GetAnswer(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(6, "Fizz")]
        [TestCase(9, "Fizz")]
        public static void should_return_Fizz_when_input_is_multiple_of_three(int input, string expected)
        {
            string actual = FizzBuzzer.GetAnswer(input);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}