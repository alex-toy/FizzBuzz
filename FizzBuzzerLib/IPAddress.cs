namespace FizzBuzzerLib
{
    public class IPAddress
    {
        public string Address { get; set; }

        public string GetBinaryAddress()
        {
            if (Address == "0.0.0.0") return "00000000.00000000.00000000.00000000";
            return Address;
        }

        private int ConvertToBinary(int decimalNumber)
        {
            if (decimalNumber == 0) return 0;
            return decimalNumber;
        }
    }
}
