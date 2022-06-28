
using NUnit.Framework;
using System;
// чтобы работало в управлениях пакетами NuGet ()
namespace WindowsFormsApp2.Tests
{
    [TestFixture]
    public class UnitTest2
    {
        [Test]
        [TestCase("substract", typeof(SubtractionCalculator))]
        [TestCase("Multiplic", typeof(MultiplicationCalculator))]
        [TestCase("Division", typeof(DivisionCalculator))]
        [TestCase("Addition", typeof(AdditionalCalculator))]
        [TestCase("Pow", typeof(PowCalculator))]
        [TestCase("AntiPow", typeof(AntiPowCalculator))]
        [TestCase("Sred", typeof(SredCalculator))]
        [TestCase("", typeof(ZeroCalculator))]
        

  
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator =TwoArgFactory.CreateCalculator(name);

            Assert.IsInstanceOf(  type, calculator);
        }

    }
}
