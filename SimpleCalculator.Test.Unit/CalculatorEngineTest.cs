using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly Simple_Calculator.CalculatorEngine _calculatorEngine = new Simple_Calculator.CalculatorEngine();
        [TestMethod]
        public void AddTwoNumbersAndReturnValidResultForNonSymbolOperation()
        {
            int numberOne = 5;
            int numberTwo = 10;
            double result = _calculatorEngine.calculate("add", numberOne, numberTwo);

            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void AddTwoNumbersAndReturnValidResultForSymbolOperation()
        {
            int numberOne = 5;
            int numberTwo = 10;
            double result = _calculatorEngine.calculate("+", numberOne, numberTwo);

            Assert.AreEqual(15, result);
        }

    }
}
