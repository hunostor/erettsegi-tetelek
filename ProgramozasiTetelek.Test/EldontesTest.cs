using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ProgramozasiTetelek.Test
{
    [TestClass]
    public class EldontesTest
    {
        [TestMethod]
        public void Csak_15_nel_kisebbek_vannak_a_sorozatban_True_ra_vegzodik()
        {           
            // Act
            List<int> sorozat = new List<int>() { 3, 4, 5 };
            Eldontes eldontes = new Eldontes();
            int feltetelErtek = 15;
            // Arrange
            var actual = eldontes.Operation(sorozat, s => { return s <= feltetelErtek; });
            // Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void Egyszer_fut_le_a_ciklus_mar_az_elso_elem_megfelel()
        {
            // Act
            List<int> sorozat = new List<int>() { 3, 4, 5 };
            Eldontes eldontes = new Eldontes();
            int feltetelErtek = 15;
            // Arrange
            var actual = eldontes.Operation(sorozat, s => { return s <= feltetelErtek; });
            // Assert
            Assert.AreEqual(1, eldontes.CikusFutasSzama);
        }

        [TestMethod]
        public void Minden_elem_nagyobb_mint_15_vegig_lefut_a_ciklus()
        {
            // Act
            List<int> sorozat = new List<int>() { 345, 42, 52 };
            Eldontes eldontes = new Eldontes();
            int feltetelErtek = 15;
            // Arrange
            var actual = eldontes.Operation(sorozat, s => { return s <= feltetelErtek; });
            // Assert
            Assert.AreEqual(false, actual);
            Assert.AreEqual(3, eldontes.CikusFutasSzama);
        }

        [TestMethod]
        public void Negyedik_elem_felel_meg_a_feltetelnek()
        {
            // Act
            List<int> sorozat = new List<int>() { 114, 24, 54, 11 };
            Eldontes eldontes = new Eldontes();
            int feltetelErtek = 15;
            // Arrange
            var actual = eldontes.Operation(sorozat, s => { return s <= feltetelErtek; });
            // Assert
            Assert.AreEqual(true, actual);
            Assert.AreEqual(3, eldontes.CikusFutasSzama);
        }

        [TestMethod]
        public void negativ_szam_van_a_sorozatban()
        {
            // Act
            List<int> sorozat = new List<int>() { 114, 24, -12, 54, -123, 11 };
            Eldontes eldontes = new Eldontes();
            int feltetelErtek = 15;
            // Arrange
            var actual = eldontes.Operation(sorozat, s => { return s <= feltetelErtek; });
            // Assert
            Assert.AreEqual(true, actual);
            Assert.AreEqual(2, eldontes.CikusFutasSzama);
        }

        [TestMethod]
        public void uj_feltetel_megadas()
        {
            // Act
            List<int> sorozat = new List<int>() { 114, 24, -12, 54, -123, 12, 11 };
            Eldontes eldontes = new Eldontes();
            int feltetelErtek = 24;
            // Arrange
            var actual = eldontes.Operation(sorozat, s => { return s * 2 == feltetelErtek ; });
            // Assert
            Assert.AreEqual(true, actual);
            Assert.AreEqual(5, eldontes.CikusFutasSzama);
        }
    }
}
