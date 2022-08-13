﻿using FizzBuzz;
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
        [TestCase(10, "Buzz")]
        [TestCase(15, "Buzz")]
        public static void should_return_proper_output_when_input_is_multiple_of_three_or_five(int input, string expected)
        {
            string actual = FizzBuzzer.GetAnswer(input);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}