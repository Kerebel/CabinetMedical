using CabinetMedical.ClassesMetier;
using CabinetMedical.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestCabinetMedical
{
    [TestClass]
    public class PrestationTest
    {
        [TestMethod]
        public void TesteDatePrestationInferieureOuEgaleDateDuJourOK()
        {
            Prestation p1 = new Prestation("P1", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            Assert.IsInstanceOfType(p1, typeof(Prestation));
        }

        [TestMethod]
        [ExpectedException(typeof(CabinetMedicalException))]
        public void TesteDatePrestationInferieureOuEgaleDateDuJourKO()
        {
            Prestation p1 = new Prestation("P1", new DateTime(2021, 11, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            Assert.IsInstanceOfType(p1, typeof(Prestation));
        }
        [TestMethod]
        public void TestCompareToDateAnterieureALaDeuxiemeDate()
        {
            Prestation p1 = new Prestation("P1", new DateTime(2021, 09, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            Prestation p2 = new Prestation("P2", new DateTime(2021, 09, 15, 12, 0, 0), new Intervenant("Dumont", "Hubert"));
            Assert.AreEqual(-1, Prestation.CompareTo(p1, p2));
        }
        [TestMethod]
        public void TestCompareToDateEgaleALaDeuxiemeDate()
        {
            Prestation p1 = new Prestation("P1", new DateTime(2021, 09, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            Prestation p2 = new Prestation("P2", new DateTime(2021, 09, 10, 14, 0, 0), new Intervenant("Dumont", "Hubert"));
            Assert.AreEqual(0, Prestation.CompareTo(p1, p2));
        }
        [TestMethod]
        public void TestCompareToDatePosterieureALaDeuxiemeDate()
        {
            Prestation p1 = new Prestation("P1", new DateTime(2021, 09, 20, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            Prestation p2 = new Prestation("P2", new DateTime(2021, 09, 15, 12, 0, 0), new Intervenant("Dumont", "Hubert"));
            Assert.AreEqual(1, Prestation.CompareTo(p1, p2));
        }

    }
}
