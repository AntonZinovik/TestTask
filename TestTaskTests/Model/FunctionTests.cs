using TestTask;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTask.Tests
{
    [TestClass()]
    public class FunctionTests
    {
        [TestMethod()]
        public void TestLinearFunction()
        {
            double VariableA = 2, VariableB = 3, VariableX = 1, VariableY = 2;
            int VariableCNumber = 5;
            double expected = 10;
            double Result = Function.LinearFunction(VariableA, VariableB, VariableCNumber, VariableX, VariableY);
            Assert.AreEqual(expected, Result);
        }

        [TestMethod()]
        public void QuadraticFunctionTest()
        {
            double VariableA = 2, VariableB = 3, VariableX = 1, VariableY = 2;
            int VariableCNumber = 10;
            double expected = 18;
            double Result = Function.QuadraticFunction(VariableA, VariableB, VariableCNumber, VariableX, VariableY);
            Assert.AreEqual(expected, Result);
        }

        [TestMethod()]
        public void СubicFunctionTest()
        {
            double VariableA = 2, VariableB = 3, VariableX = 1, VariableY = 2;
            int VariableCNumber = 100;
            double expected = 114;
            double Result = Function.СubicFunction(VariableA, VariableB, VariableCNumber, VariableX, VariableY);
            Assert.AreEqual(expected, Result);
        }

        [TestMethod()]
        public void FourthDegreeFunctionTest()
        {
            double VariableA = 2, VariableB = 3, VariableX = 1, VariableY = 2;
            int VariableCNumber = 1000;
            double expected = 1026;
            double Result = Function.FourthDegreeFunction(VariableA, VariableB, VariableCNumber, VariableX, VariableY);
            Assert.AreEqual(expected, Result);
        }

        [TestMethod()]
        public void FifthDegreeFunctionTest()
        {
            double VariableA = 2, VariableB = 3, VariableX = 1, VariableY = 2;
            int VariableCNumber = 10000;
            double expected = 10050;
            double Result = Function.FifthDegreeFunction(VariableA, VariableB, VariableCNumber, VariableX, VariableY);
            Assert.AreEqual(expected, Result);
        }
    }
}