using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Carle.Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void MultipleItemsMultipleDuplicates()
        {
            string originalString = "[VICTOR],[ECHO],[BRAVO],[BRAVO],[OSCAR],[ECHO],[PAPA],[BRAVO]";
            List<string> originalList = new();
            originalList.AddRange(originalString.Split(','));

            List<string> duplicates = originalList.GetDuplicates(); //method to get duplicates

            Assert.AreEqual(2, duplicates.Count);
            Assert.IsTrue(duplicates.Contains("[ECHO]"));
            Assert.IsTrue(duplicates.Contains("[BRAVO]"));
        }

        [TestMethod]
        public void MultipleItemsSingleDuplicates()
        {
            string originalString = "[VICTOR],[ECHO],[BRAVO],[BRAVO],[OSCAR],[PAPA],[BRAVO]";
            List<string> originalList = new();
            originalList.AddRange(originalString.Split(','));

            List<string> duplicates = originalList.GetDuplicates(); //method to get duplicates

            Assert.AreEqual(1, duplicates.Count);
            Assert.IsTrue(duplicates.Contains("[BRAVO]"));
        }

        [TestMethod]
        public void Empty()
        {
            List<string> originalList = new();

            List<string> duplicates = originalList.GetDuplicates(); //method to get duplicates

            Assert.AreEqual(0, duplicates.Count);
        }

        [TestMethod]
        public void SingleItemNoDuplicate()
        {
            string originalString = "[VICTOR]";
            List<string> originalList = new();
            originalList.AddRange(originalString.Split(','));

            List<string> duplicates = originalList.GetDuplicates(); //method to get duplicates

            Assert.AreEqual(0, duplicates.Count);
        }

        [TestMethod]
        public void SingleItemSingleDuplicate()
        {
            string originalString = "[VICTOR],[VICTOR],[VICTOR],[VICTOR],[VICTOR]";
            List<string> originalList = new();
            originalList.AddRange(originalString.Split(','));

            List<string> duplicates = originalList.GetDuplicates(); //method to get duplicates

            Assert.AreEqual(1, duplicates.Count);
            Assert.IsTrue(duplicates.Contains("[VICTOR]"));
        }

        [TestMethod]
        public void MultipleItemsNoDuplicates()
        {
            string originalString = "[VICTOR],[ECHO],[BRAVO],[OSCAR],[PAPA]";
            List<string> originalList = new();
            originalList.AddRange(originalString.Split(','));

            List<string> duplicates = originalList.GetDuplicates(); //method to get duplicates

            Assert.AreEqual(0, duplicates.Count);
        }

        [TestMethod]
        public void MultipleItemsMultipleEmptyStrings()
        {
            string originalString = "[VICTOR],[ECHO],[BRAVO],[BRAVO],[OSCAR],[ECHO],[PAPA],[BRAVO]";
            List<string> originalList = new();
            originalList.Add(string.Empty);
            originalList.AddRange(originalString.Split(','));
            originalList.Add(string.Empty);

            List<string> duplicates = originalList.GetDuplicates(); //method to get duplicates

            Assert.AreEqual(3, duplicates.Count);
            Assert.IsTrue(duplicates.Contains("[ECHO]"));
            Assert.IsTrue(duplicates.Contains("[BRAVO]"));
            Assert.IsTrue(duplicates.Contains(string.Empty));
        }

        [TestMethod]
        public void MultipleItemsSingleEmptyString()
        {
            string originalString = "[VICTOR],[ECHO],[BRAVO],[BRAVO],[OSCAR],[ECHO],[PAPA],[BRAVO]";
            List<string> originalList = new();
            originalList.Add(string.Empty);
            originalList.AddRange(originalString.Split(','));

            List<string> duplicates = originalList.GetDuplicates(); //method to get duplicates

            Assert.AreEqual(2, duplicates.Count);
            Assert.IsTrue(duplicates.Contains("[ECHO]"));
            Assert.IsTrue(duplicates.Contains("[BRAVO]"));
        }

        [TestMethod]
        public void MultipleItemsMultipleNulls()
        {
            string originalString = "[VICTOR],[ECHO],[BRAVO],[BRAVO],[OSCAR],[ECHO],[PAPA],[BRAVO]";
            List<string> originalList = new();
            originalList.Add(null);
            originalList.AddRange(originalString.Split(','));
            originalList.Add(null);

            List<string> duplicates = originalList.GetDuplicates(); //method to get duplicates

            Assert.AreEqual(3, duplicates.Count);
            Assert.IsTrue(duplicates.Contains("[ECHO]"));
            Assert.IsTrue(duplicates.Contains("[BRAVO]"));
            Assert.IsTrue(duplicates.Contains(null));
        }

        [TestMethod]
        public void MultipleItemsSingleNull()
        {
            string originalString = "[VICTOR],[ECHO],[BRAVO],[BRAVO],[OSCAR],[ECHO],[PAPA],[BRAVO]";
            List<string> originalList = new();
            originalList.Add(null);
            originalList.AddRange(originalString.Split(','));

            List<string> duplicates = originalList.GetDuplicates(); //method to get duplicates

            Assert.AreEqual(2, duplicates.Count);
            Assert.IsTrue(duplicates.Contains("[ECHO]"));
            Assert.IsTrue(duplicates.Contains("[BRAVO]"));
        }

        [TestMethod]
        public void MultipleItemsSingleNullSingleEmpty()
        {
            string originalString = "[VICTOR],[ECHO],[BRAVO],[BRAVO],[OSCAR],[ECHO],[PAPA],[BRAVO]";
            List<string> originalList = new();
            originalList.Add(null);
            originalList.AddRange(originalString.Split(','));
            originalList.Add(string.Empty);

            List<string> duplicates = originalList.GetDuplicates(); //method to get duplicates

            Assert.AreEqual(2, duplicates.Count);
            Assert.IsTrue(duplicates.Contains("[ECHO]"));
            Assert.IsTrue(duplicates.Contains("[BRAVO]"));
        }
    }
}
