using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabinetMedical.ClassesMetier;
using CabinetMedical.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestCabinetMedical
{
    [TestClass]
    class CotationTest
    {
        [TestMethod]
        public void TestInstanceCotationOK()
        {
            Cotation cotation = new Cotation("C1", "cot1", 1);
            Assert.IsInstanceOfType(cotation, typeof(Cotation));
        }

        [TestMethod]
        [ExpectedException(typeof(CabinetMedicalException))]

        public void TestInstanceCotationKO()
        {
            Cotation cotation = new Cotation("C1", "cot1", -1);
        }
    }
}
