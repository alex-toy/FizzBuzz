namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FizzBuzz!");
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
