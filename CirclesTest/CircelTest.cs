using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circles;
using System;

namespace CirclesTest
{
    [TestClass]
    public class CircelTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Math.PI, Circle.Area(1));
        }
    }
}
