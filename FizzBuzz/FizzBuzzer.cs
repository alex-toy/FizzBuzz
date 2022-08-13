namespace FizzBuzz
{
    public static class FizzBuzzer
    {
        public static string GetAnswer(int input)
        {
            if (input % 3 == 0) return "Fizz";
            if (input % 5 == 0) return "Buzz";
            return input.ToString();
        }
    }
}
