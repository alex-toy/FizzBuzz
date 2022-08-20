using FizzBuzzerLib;

namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            FizzBuzzerDisplay();
        }

        private static void FizzBuzzerDisplay()
        {
            Console.WriteLine("Welcome to FizzBuzz!");
            Dictionary<string, int> word_Numbers = new() { { "Fizz", 3 }, { "Buzz", 5 } };
            FizzBuzzer fb = new()
            {
                Word_Numbers = word_Numbers
            };

            int begin = 1;
            int end = 100;

            fb.ShowResults(word_Numbers, begin, end);
        }
    }
}
