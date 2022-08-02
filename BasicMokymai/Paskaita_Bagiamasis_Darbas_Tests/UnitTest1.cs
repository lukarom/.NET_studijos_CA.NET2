using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_Bagiamasis_Darbas_Tests
{
    [TestClass()]
    public class BaigiamasisDarbasTestai
    {
        [TestMethod]
        public void BaigiamasisDarbasTest1()
        {

            Paskaita_Baigiamasis_Darbas.Program.Reset();

            var fake_moves = new string[] { "m", "a", "r", "i", "n", "a" };
            var actual = "marina";
            Paskaita_Baigiamasis_Darbas.Program.word = "Marina";
            foreach (var move in fake_moves)
            {
                Paskaita_Baigiamasis_Darbas.Program.HangmanGame(move);
            }
            var expected = Paskaita_Baigiamasis_Darbas.Program.ResultWord();

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void BaigiamasisDarbasTest2()
        {

            Paskaita_Baigiamasis_Darbas.Program.Reset();

            var fake_moves = new string[] {"marina"};
            var actual = "marina";
            Paskaita_Baigiamasis_Darbas.Program.word = "Marina";
            foreach (var move in fake_moves)
            {
                Paskaita_Baigiamasis_Darbas.Program.HangmanGame(move);
            }
            var expected = Paskaita_Baigiamasis_Darbas.Program.ResultWord();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BaigiamasisDarbasTest3()
        {
            Paskaita_Baigiamasis_Darbas.Program.Reset();

            var fake_moves = new string[] { "Marina" }; //ivestas vardas is dideles raides
            var actual = "marina";
            Paskaita_Baigiamasis_Darbas.Program.word = "Marina";
            foreach (var move in fake_moves)
            {
                Paskaita_Baigiamasis_Darbas.Program.HangmanGame(move);
            }
            var expected = Paskaita_Baigiamasis_Darbas.Program.ResultWord();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BaigiamasisDarbasTest4()
        {
            Paskaita_Baigiamasis_Darbas.Program.Reset();

            var fake_moves = new string[] {"Marana"}; //ivestas vardas is dideles raides
            var actual = true;
            Paskaita_Baigiamasis_Darbas.Program.word = "Marina";
            foreach (var move in fake_moves)
            {
                Paskaita_Baigiamasis_Darbas.Program.HangmanGame(move);
            }
            var expected = Paskaita_Baigiamasis_Darbas.Program.IfAnswerWrong();

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void BaigiamasisDarbasTest5()
        {
            Paskaita_Baigiamasis_Darbas.Program.Reset();

            var fake_moves = new string[] { "marina" }; //ivestas vardas is dideles raides
            var actual = true;
            Paskaita_Baigiamasis_Darbas.Program.word = "Marina";
            foreach (var move in fake_moves)
            {
                Paskaita_Baigiamasis_Darbas.Program.HangmanGame(move);
            }
            var expected = Paskaita_Baigiamasis_Darbas.Program.IfAnswerCorrect();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BaigiamasisDarbasTest6()
        {
            Paskaita_Baigiamasis_Darbas.Program.Reset();

            var fake_moves = new string[] { "makjl8098kjina" }; //ivestas per ilgas žodis su skaitmenimis
            var actual = true;
            Paskaita_Baigiamasis_Darbas.Program.word = "Marina";
            foreach (var move in fake_moves)
            {
                Paskaita_Baigiamasis_Darbas.Program.HangmanGame(move);
            }
            var expected = Paskaita_Baigiamasis_Darbas.Program.IfAnswerWrong();

            Assert.AreEqual(expected, actual);
        }
    }
}