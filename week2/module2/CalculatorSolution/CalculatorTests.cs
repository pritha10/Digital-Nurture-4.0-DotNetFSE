using CalcLibrary;
using CalcLibrary1;
using NUnit.Framework;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [TearDown]
        public void Cleanup()
        {
            _calculator = null;
        }

        [Test]
        [TestCase(2, 3, 5)]
        [TestCase(10, 5, 15)]
        [TestCase(-1, 1, 0)]
        public void Add_WhenCalled_ReturnsCorrectSum(int a, int b, int expected)
        {
            var result = _calculator.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
