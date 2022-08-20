using FizzBuzzerLib;

namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            //FizzBuzzerDisplay();
            IPAddressDisplay();
        }

        private static void IPAddressDisplay()
        {
            IPAddress ip = new IPAddress
            {
                Address = "3.2.3.4"
            };

            var temp = ip.GetBinaryAddress();
            Console.WriteLine(temp);
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
