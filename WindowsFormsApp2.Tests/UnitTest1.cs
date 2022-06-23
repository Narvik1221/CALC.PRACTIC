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
            double actual = f.addition(a,b);
            Assert.AreEqual(expected, actual,"fail");
        }
        [TestMethod]
        public void TestMethod2()
        {
            double a = 5, b = 8;
            double expected = a-b;
            Form1 f = new Form1();
            double actual = f.subtraction(a, b);
            Assert.AreEqual(expected, actual, "fail");
        }
        [TestMethod]
        public void TestMethod3()
        {
            double a = 5, b = 8;
            double expected = a*b;
            Form1 f = new Form1();
            double actual = f.multiplication(a, b);
            Assert.AreEqual(expected, actual, "fail");
        }
        [TestMethod]
        public void TestMethod4()
        {
            double a = 10, b = 8;
            double expected = a/b;
            Form1 f = new Form1();
            double actual = f.division(a, b);
            Assert.AreEqual(expected, actual, "fail");
        }
    }
}
