using Microsoft.VisualStudio.TestTools.UnitTesting;
using Paskaita_21_Super_Skaiciuotuvas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_21_Super_Skaiciuotuvas.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void SuperSkaiciuotuvasTest1()
        {
            var fake_moves = new string[] { "1", "1", "15", "45", "2", "2", "10", "3" };
            var expected = 50d;

            Program.Reset();
            foreach (var move in fake_moves)
            {
                Program.SuperSkaiciuotuvas(move);
            }
            var actual = Paskaita_21_Super_Skaiciuotuvas.Program.Rezultatas();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SuperSkaiciuotuvasTest2()
        {
            var fake_moves = new string[] { "1", "1", "15", "45", "3" };
            var expected = 60d;
            Paskaita_21_Super_Skaiciuotuvas.Program.Reset();
            foreach (var move in fake_moves)
            {
                Paskaita_21_Super_Skaiciuotuvas.Program.SuperSkaiciuotuvas(move);
            }
            var actual = Paskaita_21_Super_Skaiciuotuvas.Program.Rezultatas();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SuperSkaiciuotuvasTest3()
        {
            var fake_moves = new string[] { "1", "1", "15", "45", "2", "2", "10", "1", "3", "2", "3", "3" };
            var expected = 6d;

            Paskaita_21_Super_Skaiciuotuvas.Program.Reset();
            foreach (var move in fake_moves)
            {
                Paskaita_21_Super_Skaiciuotuvas.Program.SuperSkaiciuotuvas(move);
            }
            var actual = Paskaita_21_Super_Skaiciuotuvas.Program.Rezultatas();

            Assert.AreEqual(expected, actual);
        }
    }
}