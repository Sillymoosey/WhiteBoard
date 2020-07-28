using System;
using TimeFunction;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TimeFunctiontest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TimeTest1()
        {
            Assert.AreEqual(15, Program.timeBetween(10, 55, 11, 10));
        }
        public void TimeTest2()
        {
            Assert.AreEqual(15, Program.timeBetween(10, 55, 11, 10));
        }
    }
}
