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

        [Test]
        public void Should_return_empty_string_when_input_is_empty_string()
        {
            ip.Address = string.Empty;
            string actual = ip.GetBinaryAddress();
            Assert.That(actual, Is.EqualTo(string.Empty));
        }

        [TestCase("0.0.0.0", "00000000.00000000.00000000.00000000")]
        public void Should_return_zeros_when_input_is_0_0_0_0(string decimalAddress, string binaryAddress)
        {
            ip.Address = decimalAddress;
            string actual = ip.GetBinaryAddress();
            string expected = binaryAddress;
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}