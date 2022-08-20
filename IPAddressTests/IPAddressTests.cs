using NUnit.Framework;
using FizzBuzzerLib;

namespace IPAddressTests
{
    public class IPAddressTests
    {
        private readonly IPAddress ip;

        public IPAddressTests()
        {
            ip = new IPAddress();
        }

        [SetUp]
        public void Setup()
        {
            IPAddress ip = new IPAddress();
        }

        [TestCase("0.0.0.0", "00000000.00000000.00000000.00000000")]
        [TestCase("", "")]
        [TestCase("1.2.3.4", "00000001.00000010.00000011.00000100")]
        [TestCase("255.2.3.4", "11111111.00000010.00000011.00000100")]
        public void Should_return_proper_ouput_when_input_is_given(string decimalAddress, string binaryAddress)
        {
            ip.Address = decimalAddress;
            string actual = ip.GetBinaryAddress();
            Assert.That(actual, Is.EqualTo(binaryAddress));
        }
    }
}