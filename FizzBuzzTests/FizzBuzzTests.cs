using FizzBuzz;
using NUnit.Framework;

namespace FizzBuzzTests
{
    [TestFixture]
    public class FizzBuzztests
    {
        [TestCase(1, "1")]
        public static void should_return_output_when_input_is_given(int input, string output)
        {
            string actual = FizzBuzzer.GetAnswer(input);
            Assert.That(actual, Is.EqualTo(output));
        }
    }
}