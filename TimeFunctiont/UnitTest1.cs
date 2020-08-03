using System;
using TimeFunction;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TimeFunctiontest
{
    [TestClass]
    public class UnitTest1
    {
        DateTime Time1 = new DateTime(2020, 1, 1, 12, 50, 00);
        DateTime Time2 = new DateTime(2020, 1, 1, 13, 05, 00);
        [TestMethod]
        public void TimeTest1()
        {
            Assert.AreEqual(-1, Program.timeBetween(Time1, Time2));
        }
        public void TimeTest2()
        {
            Assert.AreEqual(1, Program.timeBetween(Time2, Time1));
        }
    }
}
