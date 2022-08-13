namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FizzBuzz!");
            FizzBuzzer.Word_Numbers = new Dictionary<string, int>() { { "Fizz", 3 }, { "Buzz", 5 } };
            ShowResult();
        }
        
        private static void ShowResult()
        {
            for (int i = 0; i <= 100; i++)
            {
                string output = FizzBuzzer.GetAnswer(i);
                Console.WriteLine($"{i} -> {output}");
            }
        }
    }
}
