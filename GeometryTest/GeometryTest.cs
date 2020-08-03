using Geometry;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryTest
{
    [TestClass]
    public class GeometryTest
    {
        [TestMethod]
        public void TestGeometry1()
        {
            Assert.AreEqual(5.0, Geometry.Geometry.TriangleArea(5.0, 2.0));
        }
        [TestMethod]
        public void TestHpyo1()
        {
            Assert.AreEqual(5.0, Geometry.Geometry.Hypo(3.0, 4.0));
        }
    }
}
