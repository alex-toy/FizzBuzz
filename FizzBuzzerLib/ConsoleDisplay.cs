using System;

namespace FizzBuzzerLib
{
    public class ConsoleDisplay : IDisplayMethod
    {
        public FizzBuzzer Fb { get; set; }

        public void ShowResults(int begin, int end)
        {
            int index = begin;

            foreach (string output in Fb.IterateRange(begin, end))
            {
                Console.WriteLine($"{index} -> {output}");
                index++;
            }
        }
    }
}
