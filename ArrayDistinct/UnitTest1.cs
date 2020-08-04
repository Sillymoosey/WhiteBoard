using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntArray;

namespace IntArray
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDistinct()
        {
            int[] myTestNumber = new int[] { 9, 2, 1, 0, 1, 4, 4 };
            Assert.AreEqual(5, IntArray.Distinct(myTestNumber));
        }
    }
}
