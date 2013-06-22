using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ExampleLibrary;

namespace Tests
{
    [TestClass]
    public class DictionaryHelperTests
    {
        [TestMethod]
        public void TestGettingValuesAsList()
        {
            // Arrange: Let's say I have a list of things and how much I like them
            DictionaryHelper.HowMuchILikeEachThing = new Dictionary<string, int>();
            DictionaryHelper.HowMuchILikeEachThing.Add("Banana", 10);
            DictionaryHelper.HowMuchILikeEachThing.Add("Peanut Butter", 50);

            // Act: Now say I want the values in that dictionary as a list
            var list = DictionaryHelper.Values;

            // Assert:
            Assert.IsNotNull(list, "The list should not be null");
            Assert.IsInstanceOfType(list, typeof(IList<int>), "The list should be some kind of IList<int>");
            Assert.AreEqual(10, list[0]);
            Assert.AreEqual(50, list[1]);
            Assert.AreEqual(DictionaryHelper.HowMuchILikeEachThing.Count, list.Count);
        }
    }
}
