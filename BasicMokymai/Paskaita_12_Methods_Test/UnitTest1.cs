namespace Paskaita_12_Methods_Test
{
    [TestClass]
    public class Paskaita_11_Metodai_Uzdaviniai_Test
    {
        [TestMethod]
        public void TekstasSuTarpaisTestas1()
        {
            var fake = "  as    mokausi programuoti   ";
            var actual = Paskaita_11_Metodai_Uzdaviniai.Program.TekstasSuTarpais(fake);
            var expected = 10;
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TekstoIlgisTestas1()
        {
            var fake = "  as    mokausi programuoti   ";
            var actual = Paskaita_11_Metodai_Uzdaviniai.Program.TekstoIlgis(fake);
            var expected = 25;
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ZodziuKiekisTest1()
        {
            var fake = "  as    mokausi programuoti   ";
            var actual = Paskaita_11_Metodai_Uzdaviniai.Program.ZodziuKiekis(fake);
            var expected = 3;
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TarpuKiekisGaleTest1()
        {
            var fake = "  as    mokausi programuoti   ";
            var actual = Paskaita_11_Metodai_Uzdaviniai.Program.TarpuKiekisGale(fake);
            var expected = 3;
            Assert.AreEqual(expected, actual);

        }
        

        [TestMethod]
        public void TarpuKiekisPriekyjeTest1()
        {
            var fake = "  as    mokausi programuoti   ";
            var actual = Paskaita_11_Metodai_Uzdaviniai.Program.TarpuKiekisPriekyje(fake);
            var expected = 2;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TarpaiPriekyjeGaleTest1()
        {
            var fake = "  as    mokausi programuoti   ";
            var expectedPriekyje = 2;
            var expectedGale = 3;
            Paskaita_11_Metodai_Uzdaviniai.Program.TarpaiPriekyjeGale(fake, out int actualGale, out int actualPriekyje);
            
            Assert.AreEqual(expectedPriekyje, actualPriekyje);
            Assert.AreEqual(expectedGale, actualGale);

        }

        [TestMethod]
        public void SurastiMaziausiaNariTest1()
        {
            int[] fake = { 5, 3, 7, 6, 8, 7, 10 }; ;
            int expected = 3;
            int actual = Paskaita_20_Masyvu_Kartojimas.Program.SurastiMaziausiaNari(fake);

            Assert.AreEqual(expected , actual);

        }

        [TestMethod]
        public void SurastiDidziausiaNariTest1()
        {
            int[] fake = { 5, 3, 7, 6, 8, 7, 10 }; ;
            int expected = 10;
            int actual = Paskaita_20_Masyvu_Kartojimas.Program.SurastiDidziausiaNari(fake);

            Assert.AreEqual(expected, actual);

        }
    }
}