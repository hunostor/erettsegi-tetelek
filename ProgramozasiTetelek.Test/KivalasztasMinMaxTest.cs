using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ProgramozasiTetelek.Test
{
    [TestClass]
    public class KivalasztasMinMaxTest
    {
        [TestMethod]
        public void select_max_in_array_when_all_positive()
        {
            // Act
            int[] arr = new int[2] { 4, 54 };
            var select = new KivalasztasMinMax();
            // Arrange
            var actual = select.Max(arr);
            // Assert
            Assert.AreEqual(54, actual);        
        }

        [TestMethod]
        public void select_max_in_array_when_many_positive()
        {
            // Act
            var arr = new int[4] { 4, 54, 45, 13 };
            var select = new KivalasztasMinMax();
            // Arrange
            var actual = select.Max(arr);
            // Assert
            Assert.AreEqual(54, actual);
        }

        [TestMethod]
        public void select_max_in_array_when_some_number_negative()
        {
            // Act
            var arr = new int[4] { 4, 54, 45, -13 };
            var select = new KivalasztasMinMax();
            // Arrange
            var actual = select.Max(arr);
            // Assert
            Assert.AreEqual(54, actual);    
        }

        [TestMethod]
        public void select_max_in_list_when_some_number_negative()
        {
            // Act
            List<int> list = new List<int>() { 4, -2, 54, 0, 45, -13 };
            var select = new KivalasztasMinMax();
            // Arrange
            var actual = select.Max(list);
            // Assert
            Assert.AreEqual(54, actual);
        }

        [TestMethod]
        public void select_max_in_list_when_all_number_negative()
        {
            // Act
            List<int> list = new List<int>() { -4, -2, -54, -45, -13 };
            var select = new KivalasztasMinMax();
            // Arrange
            var actual = select.Max(list);
            // Assert
            Assert.AreEqual(-2, actual);
        }

        [TestMethod]
        public void select_max_in_array_when_all_number_negative_and_one_null_value()
        {
            // Act
            var arr = new int[6] { -4, -2, -54, 0, -45, -13 };
            var select = new KivalasztasMinMax();
            // Arrange
            var actual = select.Max(arr);
            // Assert
            Assert.AreEqual(0, actual);
        }
    }
}
