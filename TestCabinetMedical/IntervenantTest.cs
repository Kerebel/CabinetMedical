using CabinetMedical.ClassesMetier;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestCabinetMedical
{
    [TestClass]
    public class IntervenantTest
    {
        [TestMethod]
        public void TesteGetNbPrestationsI()
        {
            Intervenant intervenant = new Intervenant("Dupont", "Pierre");
            intervenant.AjoutePrestation(new Prestation("Presta 10", new DateTime(2019, 6, 12), intervenant));
            intervenant.AjoutePrestation(new Prestation("Presta 11", new DateTime(2019, 6, 15), intervenant));
            Assert.AreEqual(2, intervenant.GetNbPrestations());
        }

        [TestMethod]
        public void TesteGetNbPrestationsIE()
        {
            IntervenantExterne intervenantExt = new IntervenantExterne("Dumoulin", "Thomas", "Cardiologue", "Rue du soleil", 0605040302);
            intervenantExt.AjoutePrestation(new Prestation("Presta 10", new DateTime(2019, 6, 12), intervenantExt));
            intervenantExt.AjoutePrestation(new Prestation("Presta 11", new DateTime(2019, 6, 15), intervenantExt));
            intervenantExt.AjoutePrestation(new Prestation("Presta 12", new DateTime(2019, 6, 17), intervenantExt));
            intervenantExt.AjoutePrestation(new Prestation("Presta 13", new DateTime(2019, 6, 18), intervenantExt));
            Assert.AreEqual(4, intervenantExt.GetNbPrestations());
        }
    }
}
