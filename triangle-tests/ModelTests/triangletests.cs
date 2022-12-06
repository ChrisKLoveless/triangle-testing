using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Triangle;

namespace Triangle.TestTools
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void AllSidesEqual_CheckForEqualSides_True()
        {
            Tri test = new Tri(1, 1, 1);
            Assert.AreEqual(true, test.AllSidesEqual());
        }

        [TestMethod]
        public void AllSidesEqual_CheckForEqualSides_False()
        {
            Tri test = new Tri(2, 1, 1);
            Assert.AreEqual(false, test.AllSidesEqual());
        }

        [TestMethod]
        public void TwoEqual_CheckIfTwoSidesAreEqual_True()
        {
            Tri test = new Tri(2, 1, 1);
            Assert.AreEqual(true, test.TwoEqual());
        }

        [TestMethod]
        public void TwoEqual_CheckIfTwoSidesAreEqual_False()
        {
            Tri test = new Tri(1, 1, 1);
            Assert.AreEqual(false, test.TwoEqual());
        }

				[TestMethod]
        public void NoSidesEqual_CheckIfNoSidesAreEqual_False()
        {
            Tri test = new Tri(1, 2, 1);
            Assert.AreEqual(false, test.NoSidesEqual());
        }

				[TestMethod]
        public void IsTriangle_CheckIfItIsATriangle_False()
        {
            Tri test = new Tri(1, 10, 12);
            Assert.AreEqual(false, test.IsTriangle());
        }

				[TestMethod]
        public void IsTriangle_CheckIfItIsATriangle_True()
        {
            Tri test = new Tri(7, 10, 5);
            Assert.AreEqual(true, test.IsTriangle());
        }
    }
}
