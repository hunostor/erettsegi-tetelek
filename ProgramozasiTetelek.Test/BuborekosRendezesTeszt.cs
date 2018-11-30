using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramozasiTetelek.Test
{
    [TestClass]
    public class BuborekosRendezesTeszt
    {        
        [TestMethod]
        public void RendezesTeszteles()
        {
            // Act
            List<int> testList = new List<int>()
            {
                32, 12, 10, 9, 45, 90, 13, 8, 1, 42
            };
            BuborekosRendezes rendezes = new BuborekosRendezes();
            List<int> actualList;
            // Arrange
            actualList = rendezes.Rendezes(testList);
            // Assert
            Assert.AreEqual(1, actualList[0]);
            Assert.AreEqual(90, actualList[9]);
            Assert.AreEqual(45, actualList[8]);
            Assert.AreEqual(8, actualList[1]);
            Assert.AreEqual(9, actualList[2]);
            Assert.AreEqual(13, actualList[5]);
        }

        [TestMethod]
        public void RendezesTeszteles_vannak_listaban_negativ_szamok_is()
        {
            // Act
            List<int> testList = new List<int>()
            {
                32, 12, 10, -3, 9, 45, 90, 13, -444, 8, 1, 42
            };
            BuborekosRendezes rendezes = new BuborekosRendezes();
            List<int> actualList;
            // Arrange
            actualList = rendezes.Rendezes(testList);
            // Assert
            Assert.AreEqual(-444, actualList[0]);
            Assert.AreEqual(-3, actualList[1]);
            Assert.AreEqual(90, actualList[11]);
        }
    }
}
