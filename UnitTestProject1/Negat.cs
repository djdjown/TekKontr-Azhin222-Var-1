using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1;

namespace ExamCalculatorTests
{
    [TestClass]
    public class ExamCalculatorNegativeTests
    {
        private ExamCalculator calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new ExamCalculator();
        }

        [TestMethod]
        public void Calculate_Task1TooHigh_ReturnsFalse()
        {
            bool result = calculator.Calculate(11, 30, 20, 5);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Calculate_Task2Negative_ReturnsFalse()
        {
            bool result = calculator.Calculate(5, -1, 20, 5);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Calculate_Task3TooHigh_ReturnsFalse()
        {
            bool result = calculator.Calculate(5, 20, 31, 5);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Calculate_Task4TooHigh_ReturnsFalse()
        {
            bool result = calculator.Calculate(5, 20, 10, 11);
            Assert.IsFalse(result);
        }
    }
}
