using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ExampleLibrary;

namespace Tests
{
    [TestClass]
    public class MathClassTests
    {
        [TestMethod]
        public void TestFactorial()
        {
            Assert.AreEqual(2 * 3 * 4 * 5, MathClass.Factorial(5));
            Assert.AreEqual(2 * 3 * 4 * 5 * 6 * 7, MathClass.Factorial(7));
        }
    }
}
