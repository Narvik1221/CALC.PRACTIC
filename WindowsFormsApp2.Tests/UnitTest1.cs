using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace WindowsFormsApp2.Tests
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        
        public void TestMethod1()
        {
            double a=5, b = 8;
            double expected = a-b;
            ITwoArgumentsCalculator test = new SubtractionCalculator();
            double actual = test.Calculate(a,b);
            Assert.AreEqual(expected, actual,"fail");
        }
        [TestMethod]
        public void TestMethod2()
        {
            double a = 5, b = 8;
            double expected = a+b;
            ITwoArgumentsCalculator test = new AdditionalCalculator();
            double actual = test.Calculate(a, b);
            Assert.AreEqual(expected, actual, "fail");
        }
        [TestMethod]
        public void TestMethod3()
        {
            double a = 5, b = 8;
            double expected = a*b;
            ITwoArgumentsCalculator test = new MultiplicationCalculator();
            double actual = test.Calculate(a, b);
            Assert.AreEqual(expected, actual, "fail");
        }
        [TestMethod]
        public void TestMethod4()
        {
            double a = 10, b = 8;
            double expected = a/b;
            ITwoArgumentsCalculator test = new DivisionCalculator();
            double actual = test.Calculate(a, b);
            Assert.AreEqual(expected, actual, "fail");
        }
        [TestMethod]
        public void TestMethod5()
        {
            double a = 27, b = 3;
            double expected = Math.Pow(a, (1 / b));
            ITwoArgumentsCalculator test = new AntiPowCalculator();
            double actual = test.Calculate(a, b);
            Assert.AreEqual(expected, actual, "fail");
        }

        [TestMethod]
        public void TestMethod6()
        {
            double a = 5;
            double expected = 1/a;
            IOneArgumentsCalculator test = new OneDivisCalculator();
            double actual = test.Calculate(a);
            Assert.AreEqual(expected, actual, "fail");
        }

        [TestMethod]
        public void TestMethod7()
        {
            double a = 5, b = 2;
            double expected = Math.Pow(a, b);
            ITwoArgumentsCalculator test = new PowCalculator();
            double actual = test.Calculate(a, b);
            Assert.AreEqual(expected, actual, "fail");
        }

        [TestMethod]
        public void TestMethod8()
        {
            double a = 81;
            double expected = Math.Sqrt(a);
            IOneArgumentsCalculator test = new SqrtCalculator();
            double actual = test.Calculate(a);
            Assert.AreEqual(expected, actual, "fail");
        }

        [TestMethod]
        public void TestMethod9()
        {
            double a = 50;
            double expected = Math.Tan(a);
            IOneArgumentsCalculator test = new TanCalculator();
            double actual = test.Calculate(a);
            Assert.AreEqual(expected, actual, "fail");
        }

        [TestMethod]
        public void TestMethod10()
        {
            double a = 50;
            double expected = Math.Atan(a);
            IOneArgumentsCalculator test = new ATanCalculator();
            double actual = test.Calculate(a);
            Assert.AreEqual(expected, actual, "fail");
        }

        [TestMethod]
        public void TestMethod11()
        {
            double a = 50;
            double expected = Math.Sin(a);
            IOneArgumentsCalculator test = new SinCalculator();
            double actual = test.Calculate(a);
            Assert.AreEqual(expected, actual, "fail");
        }

        [TestMethod]
        public void TestMethod12()
        {
            double a = 50;
            double expected = Math.Log(a);
            IOneArgumentsCalculator test = new LnCalculator();
            double actual = test.Calculate(a);
            Assert.AreEqual(expected, actual, "fail");
        }

        [TestMethod]
        public void TestMethod13()
        {
            double a = 25;
            double expected = Math.Cos(a);
            IOneArgumentsCalculator test = new CosCalculator();
            double actual = test.Calculate(a);
            Assert.AreEqual(expected, actual, "fail");
        }

        [TestMethod]
        public void TestMethod14()
        {
            double a = 27, b = 13;
            double expected = (a + b) / 2;
            ITwoArgumentsCalculator test = new SredCalculator();
            double actual = test.Calculate(a, b);
            Assert.AreEqual(expected, actual, "fail");
        }
    }

}
