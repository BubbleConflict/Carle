using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Carle
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string originalString = "[VICTOR],[ECHO],[BRAVO],[BRAVO],[OSCAR],[ECHO],[PAPA],[BRAVO]";
            List<string> originalList = new();
            originalList.AddRange(originalString.Split(','));

            List<string> duplicates = originalList.GetDuplicates(); //method to get duplicates

            Assert.AreEqual(2, duplicates.Count);
            Assert.IsTrue(duplicates.Contains("[ECHO]"));
            Assert.IsTrue(duplicates.Contains("[BRAVO]"));
        }
    }
}
