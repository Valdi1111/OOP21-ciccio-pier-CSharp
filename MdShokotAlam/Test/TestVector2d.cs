using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        private const double  Tolerance = 0.001d;
        [TestMethod]
        public void TestVector()
        {
            Vector2d v1 = new Vector2d(0, 1);
            Vector2d v2 = new Vector2d(1, 1);

            //test euclidean distance
            Assert.IsTrue(Math.Abs(1 - v1.EuclidDistance(v2)) < Tolerance);
            Vector2d sum = v1.AddVector(v2);

            Assert.IsTrue(1 == sum.X,"Failed to sum");
            Assert.IsTrue(2 == sum.Y,"Failed to sum");
            Vector2d sub  = v1.SubVector(v2);

            Assert.IsTrue(-1 == sub.X, "Failed to subtract");
            Assert.IsTrue(0 == sub.Y, "Failed to subtract");

            //test lenght

            Assert.IsTrue(Math.Abs(1 - v1.GetMagnitudeSq()) < Tolerance);
            Assert.IsTrue(Math.Abs(1 - v1.GetMagnitude()) < Tolerance);

            //test normalizes
            v1.Normalize();
            Assert.IsTrue(0 == v1.X, "Failed to normalize");
            Assert.IsTrue(1 == v2.Y, "Failed to normalize");

            v1.Add(v2);
            Assert.IsTrue(1 == v1.X, "Failed to add");
            Assert.IsTrue(2 == v1.Y, "Failed to add");

            //test scale
            v2.Scale(2);
            Assert.IsTrue(2 == v2.X, "Failed to scale");
            Assert.IsTrue(2 == v2.Y, "Failed to scale");

            //test angle
            Assert.IsTrue(Math.Abs(Math.PI / 4 - v2.GetAngle()) < Tolerance);
        }
    }
}