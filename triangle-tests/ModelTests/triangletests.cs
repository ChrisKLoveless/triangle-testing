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
    }
}
