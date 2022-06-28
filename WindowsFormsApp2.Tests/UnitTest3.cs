using NUnit.Framework;
using System;
using WindowsFormsApp2;


namespace WindowsFormsApp2.Tests
{
    [TestFixture]
    public class DataClassShould
    {


        [Test]
        public void DivisionByZero()
        {


            Assert.Throws<Exception>(() => throw new Exception("Деление на 0"));
        }
        [Test]
        public void EmptyMeaning()
        {


            Assert.Throws<Exception>(() => throw new Exception("Отсутствует значение"));
        }
    }
}