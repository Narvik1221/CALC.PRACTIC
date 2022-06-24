using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp2;

namespace WindowsFormsApp2.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a=5, b = 8;
            double expected = a+b;
            Form1 f = new Form1();
            double actual = f.Addition(a,b);
            Assert.AreEqual(expected, actual,"fail");
        }
        [TestMethod]
        public void TestMethod2()
        {
            double a = 5, b = 8;
            double expected = a-b;
            Form1 f = new Form1();
            double actual = f.Subtraction(a, b);
            Assert.AreEqual(expected, actual, "fail");
        }
        [TestMethod]
        public void TestMethod3()
        {
            double a = 5, b = 8;
            double expected = a*b;
            Form1 f = new Form1();
            double actual = f.Multiplication(a, b);
            Assert.AreEqual(expected, actual, "fail");
        }
        [TestMethod]
        public void TestMethod4()
        {
            double a = 10, b = 8;
            double expected = a/b;
            Form1 f = new Form1();
            double actual = f.Division(a, b);
            Assert.AreEqual(expected, actual, "fail");
        }
        [TestMethod]
        public void TestMethod5()
        {
            double a = 27, b = 3;
            double expected = Math.Pow(a, (1 / b));
            Form1 f = new Form1();
            double actual = f.FuncSqrtn(a, b);
            Assert.AreEqual(expected, actual, "fail");
        }

        [TestMethod]
        public void TestMethod6()
        {
            double a = 5;
            double expected = 1/a;
            Form1 f = new Form1();
            double actual = f.DivisionOne(a);
            Assert.AreEqual(expected, actual, "fail");
        }

        [TestMethod]
        public void TestMethod7()
        {
            double a = 5, b = 2;
            double expected = Math.Pow(a, b);
            Form1 f = new Form1();
            double actual = f.FuncPow(a, b);
            Assert.AreEqual(expected, actual, "fail");
        }

        [TestMethod]
        public void TestMethod8()
        {
            double a = 81;
            double expected = Math.Sqrt(a);
            Form1 f = new Form1();
            double actual = f.FuncSqrt(a);
            Assert.AreEqual(expected, actual, "fail");
        }

        [TestMethod]
        public void TestMethod9()
        {
            double a = 50;
            double expected = Math.Tan(a);
            Form1 f = new Form1();
            double actual = f.FuncTan(a);
            Assert.AreEqual(expected, actual, "fail");
        }

        [TestMethod]
        public void TestMethod10()
        {
            double a = 50;
            double expected = Math.Atan(a);
            Form1 f = new Form1();
            double actual = f.FuncAtan(a);
            Assert.AreEqual(expected, actual, "fail");
        }

        [TestMethod]
        public void TestMethod11()
        {
            double a = 50;
            double expected = Math.Sin(a);
            Form1 f = new Form1();
            double actual = f.FuncSin(a);
            Assert.AreEqual(expected, actual, "fail");
        }

        [TestMethod]
        public void TestMethod12()
        {
            double a = 50;
            double expected = Math.Log(a);
            Form1 f = new Form1();
            double actual = f.FuncLog(a);
            Assert.AreEqual(expected, actual, "fail");
        }

        [TestMethod]
        public void TestMethod13()
        {
            double a = 25;
            double expected = Math.Cos(a);
            Form1 f = new Form1();
            double actual = f.FuncCos(a);
            Assert.AreEqual(expected, actual, "fail");
        }

        [TestMethod]
        public void TestMethod14()
        {
            double a = 27, b = 13;
            double expected = (a + b) / 2;
            Form1 f = new Form1();
            double actual = f.SredZnach(a, b);
            Assert.AreEqual(expected, actual, "fail");
        }
    }

}
