using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzerLib
{
    public class IPAddress
    {
        public string Address { get; set; }
        public string BinaryAddress { get; set; }

        public string GetBinaryAddress()
        {
            if (Address == string.Empty) return string.Empty;
            return ConvertAllToBinary(Address);
        }

        public string GetDecimalAddress()
        {
            return ConvertAllToDecimal(Address);
        }

        private string ConvertAllToDecimal(string address)
        {
            if (address == string.Empty) return string.Empty;
            return string.Empty;
        }

        private string ConvertAllToBinary(string address)
        {
            List<string> numbers = address.Split('.').ToList();
            string result = numbers
                .Select(n => ConvertOneToBinary(n))
                .Aggregate((x, y) => x + "." + y);

            return result;
        }

        private string ConvertOneToBinary(string decimalNumber)
        {
            int.TryParse(decimalNumber, out int decimalNumberInt);
            string result = "00000000";
            char[] resultAsChars = result.ToCharArray();

            while(decimalNumberInt > 0)
            {
                int power = 0;
                int twoPowered = 1;
                while (twoPowered < decimalNumberInt) { 
                    power++;
                    twoPowered *= 2;
                }
                if (twoPowered > decimalNumberInt) { 
                    power--;
                    twoPowered /= 2;
                }
                decimalNumberInt -= twoPowered;
                resultAsChars[7-power] = '1';
            }

            return new string(resultAsChars);
        }
    }
}
