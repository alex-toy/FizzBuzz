﻿using System;
using System.Collections.Generic;

namespace FizzBuzzerLib
{
    public class FizzBuzzer
    {
        public Dictionary<string, int> Word_Numbers = new Dictionary<string, int>();

        public string GetAnswer(int input)
        {
            string output = HandleMulptiples(input, string.Empty);

            return string.IsNullOrEmpty(output) ? input.ToString() : output;
        }

        private string HandleMulptiples(int input, string output)
        {
            foreach (var wn in Word_Numbers)
            {
                if (input % wn.Value == 0) output += wn.Key;
            }
            return output;
        }

        private IEnumerable<string> IterateRange(int begin, int end)
        {
            for (int i = begin; i <= end; i++)
            {
                string output = this.GetAnswer(i);
                yield return output;
            }
        }

        public void ShowResults(Dictionary<string, int> word_Numbers, int begin, int end)
        {
            int index = begin;

            this.Word_Numbers = word_Numbers;

            foreach (string output in this.IterateRange(begin, end))
            {
                Console.WriteLine($"{index} -> {output}");
                index++;
            }
        }
    }
}
