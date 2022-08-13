namespace FizzBuzz
{
    public static class FizzBuzzer
    {
        public static string GetAnswer(int input)
        {
            string output = string.Empty;
            if (input % 3 == 0) output = "Fizz";
            if (input % 5 == 0) output += "Buzz";

            return string.IsNullOrEmpty(output) ? input.ToString() : output;
        }
    }
}
