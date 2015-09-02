using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WalterCodingTask.Tests
{
    [TestClass]
    public class NumericSequenceCalcTests
    {
        [TestMethod]
        public void TestAllNumbers()
        {
            var calc = new NumericSequenceCalc();
            string strOutput = calc.AllNumbers(16);
            Assert.AreEqual("12345678910111213141516", strOutput);
        }

        [TestMethod]
        public void TestAllOddNumbers()
        {
            var calc = new NumericSequenceCalc();
            string strOutput = calc.AllOddNumbers(16);
            Assert.AreEqual("1357911131516", strOutput);
        }

        [TestMethod]
        public void TestAllEvenNumbers()
        {
            var calc = new NumericSequenceCalc();
            string strOutput = calc.AllEvenNumbers(16);
            Assert.AreEqual("246810121416", strOutput);
        }

        [TestMethod]
        public void TestMultOfThree()
        {
            var calc = new NumericSequenceCalc();
            string strOutput = calc.MultOfThree(16);
            Assert.AreEqual("12C45C78C1011C1314C16", strOutput);
        }

        [TestMethod]
        public void TestMultOfFive()
        {
            var calc = new NumericSequenceCalc();
            string strOutput = calc.MultOfFive(16);
            Assert.AreEqual("1234E6789E11121314E16", strOutput);
        }

        [TestMethod]
        public void TestMultOfThreeFive()
        {
            var calc = new NumericSequenceCalc();
            string strOutput = calc.MultOfThreeFive(16);
            Assert.AreEqual("1234567891011121314Z16", strOutput);
        }

        [TestMethod]
        public void TestFibonacci()
        {
            var calc = new NumericSequenceCalc();
            string strOutput = calc.Fibonacci(16);
            Assert.AreEqual("1123581316", strOutput);
        }
    }
}
