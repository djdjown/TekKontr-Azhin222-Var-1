using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1; 

namespace ExamCalculatorTests
{
    [TestClass]
    public class ExamCalculatorPositiveTests
    {
        private ExamCalculator calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new ExamCalculator();
        }

        [TestMethod]
        public void Calculate_PerfectScore_ReturnsGrade5()
        {
            bool result = calculator.Calculate(10, 50, 30, 10);
            Assert.IsTrue(result);
            Assert.AreEqual(100, calculator.TotalScore);
            Assert.AreEqual("5", calculator.Grade);
        }

        [TestMethod]
        public void Calculate_JustEnoughForGrade4()
        {
            bool result = calculator.Calculate(0, 20, 15, 5); 
            Assert.IsTrue(result);
            Assert.AreEqual(40, calculator.TotalScore);
            Assert.AreEqual("4", calculator.Grade);
        }

        [TestMethod]
        public void Calculate_JustEnoughForGrade3()
        {
            bool result = calculator.Calculate(5, 10, 3, 2); 
            Assert.IsTrue(result);
            Assert.AreEqual(20, calculator.TotalScore);
            Assert.AreEqual("3", calculator.Grade);
        }

        [TestMethod]
        public void Calculate_MinScore_ReturnsGrade2()
        {
            bool result = calculator.Calculate(0, 0, 0, 0);
            Assert.IsTrue(result);
            Assert.AreEqual(0, calculator.TotalScore);
            Assert.AreEqual("2", calculator.Grade);
        }
    }
}
