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
            Prestation p1 = new Prestation("P3", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            Assert.IsInstanceOfType(p1, typeof(Prestation));
        }

        [TestMethod]
        [ExpectedException(typeof(CabinetMedicalException))]
        public void TesteDatePrestationInferieureOuEgaleDateDuJourKO()
        {
            Prestation p1 = new Prestation("P3", new DateTime(2021, 11, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            Assert.IsInstanceOfType(p1, typeof(Prestation));
        }

    }
}
