namespace FizzBuzz
{
    public static class FizzBuzzer
    {
        public static string GetAnswer(int input)
        {
            if (input % 3 == 0) return "Fizz";
            return input.ToString();
        }
    }
}
