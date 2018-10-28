using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ProgramozasiTetelek.Test
{
    [TestClass]
    public class OsszegzesAlgoTest
    {
        [TestMethod]
        public void Osszegzes_are_two_positive_integer()
        {
            // Act 
            int[] arr = new int[2] { 1, 1 };
            var algo = new OsszegzesAlgo();

            // Arrange
            var actual = algo.Osszegzes(arr);

            // Assert
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void Osszegzes_are_one_negative_integer()
        {
            // Act 
            int[] arr = new int[2] { -1, 1 };
            var algo = new OsszegzesAlgo();

            // Arrange
            var actual = algo.Osszegzes(arr);

            // Assert
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Osszegzes_are_two_negative_integer()
        {
            // Act 
            int[] arr = new int[2] { -1, -1 };
            var algo = new OsszegzesAlgo();

            // Arrange
            var actual = algo.Osszegzes(arr);

            // Assert
            Assert.AreEqual(-2, actual);
        }

        [TestMethod]
        public void Osszegzes_are_one_0_integer()
        {
            // Act 
            int[] arr = new int[2] { 0, -1 };
            var algo = new OsszegzesAlgo();

            // Arrange
            var actual = algo.Osszegzes(arr);

            // Assert
            Assert.AreEqual(-1, actual);
        }

        [TestMethod]
        public void Osszegzes_are_to_many_integer()
        {
            // Act 
            int[] arr = new int[4] { 0, -1, 5, -3 };
            var algo = new OsszegzesAlgo();

            // Arrange
            var actual = algo.Osszegzes(arr);

            // Assert
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void Osszegzes_test_convert_list()
        {
            // Act 
            List<int> list = new List<int>() { 0, -1, 5, -3 };
            
            var algo = new OsszegzesAlgo();

            // Arrange
            var actual = algo.Osszegzes(list);

            // Assert
            Assert.AreEqual(1, actual);
        }
    }
}
