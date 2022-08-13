namespace FizzBuzz
{
    public static class FizzBuzzer
    {
        public static Dictionary<string, int> Word_Numbers = new Dictionary<string,int>();

        public static string GetAnswer(int input)
        {
            string output = string.Empty;

            HandleMulptiples(input, ref output);

            return string.IsNullOrEmpty(output) ? input.ToString() : output;
        }

        private static void HandleMulptiples(int input, ref string output)
        {
            foreach (var wn in Word_Numbers)
            {
                if (input % wn.Value == 0) output += wn.Key;
            }
        }
    }
}
