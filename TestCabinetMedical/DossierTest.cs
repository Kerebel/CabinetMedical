using System;
using System.Collections.Generic;
using System.Text;
using CabinetMedical.ClassesMetier;
using CabinetMedical.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCabinetMedical
{
    [TestClass]
    public class DossierTest
    {
        //[TestMethod]
        //public void TestDateCreationDossierOK()
        //{
        //    Dossier unDossier = new Dossier("Delatre", "Charles", new DateTime(1999, 10, 05), new DateTime(2021, 09, 15));
        //    Assert.IsTrue(DateTime.Compare(unDossier.DateCreation.Date, DateTime.Now.Date) <= 0);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(CabinetMedicalException))]
        //public void TestDateCreationDossierKO()
        //{
        //    DateTime dateCreationDossier = DateTime.Now.AddDays(10);
        //    Dossier unDossier = new Dossier("Delatre", "Charles", new DateTime(1991, 10, 07), dateCreationDossier);
        //}

        //[TestMethod]
        //public void TesteDatePrestationSuperieureDateCreationDossierOK()
        //{
        //    List<Prestation> listePrestations = new List<Prestation>();
        //    Dossier unDossier = new Dossier("Robert", "Jean", new DateTime(1980, 12, 3), new DateTime(2009, 07, 1), listePrestations);
        //    Prestation p1 = new Prestation("P3", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
        //    unDossier.AjoutePrestation(p1);
        //    Assert.IsInstanceOfType(unDossier, typeof(Dossier));
        //}

        //[TestMethod]
        //[ExpectedException(typeof(CabinetMedicalException))]
        //public void TesteDatePrestationSuperieureDateCreationDossierKO()
        //{
        //    List<Prestation> listePrestations = new List<Prestation>();
        //    Dossier unDossier = new Dossier("Robert", "Jean", new DateTime(1980, 12, 3), DateTime.Now.AddDays(50), listePrestations);
        //    Prestation p1 = new Prestation("P3", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
        //    unDossier.AjoutePrestation(p1);
        //    Assert.IsInstanceOfType(unDossier, typeof(Dossier));
        //}

        //[TestMethod]
        //public void TesteGetNbPrestationsExternes()
        //{
        //    List<Prestation> listePrestations = new List<Prestation>();
        //    Dossier unDossier = new Dossier("Robert", "Jean", new DateTime(1980, 12, 3), new DateTime(2009, 07, 1), listePrestations);
        //    Prestation p = new Prestation("P3", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
        //    Prestation pExt = new Prestation("P3", new DateTime(2015, 9, 10, 12, 0, 0), new IntervenantExterne("Tourette", "Pierro", "Psychologue", "Rue du soleil", 0600000000));
        //    unDossier.AjoutePrestation(p);
        //    unDossier.AjoutePrestation(pExt);
        //    Assert.AreEqual(1, unDossier.GetNbPrestationsExternes());
        //}

        //[TestMethod]
        //public void TesteNbJoursSoins()
        //{
        //    List<Prestation> listePrestations = new List<Prestation>();
        //    Dossier unDossier = new Dossier("L'asticot", "Toto", new DateTime(1980, 12, 3), new DateTime(2009, 07, 1), listePrestations);
        //    Prestation p1 = new Prestation("P1", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
        //    Prestation p2 = new Prestation("P2", new DateTime(2015, 9, 11, 13, 0, 0), new Intervenant("Bellemare", "Pierre"));
        //    unDossier.AjoutePrestation(p1);
        //    unDossier.AjoutePrestation(p2);
        //    Assert.AreEqual(2, unDossier.GetNbJoursSoinsV1());
        //}

        //[TestMethod]
        //public void TesteNbJoursSoinsV2()
        //{
        //    List<Prestation> listePrestations = new List<Prestation>();
        //    Dossier unDossier = new Dossier("L'asticot", "Toto", new DateTime(1980, 12, 3), new DateTime(2009, 07, 1), listePrestations);
        //    Prestation p1 = new Prestation("P1", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
        //    Prestation p2 = new Prestation("P2", new DateTime(2015, 9, 11, 13, 0, 0), new Intervenant("Bellemare", "Pierre"));
        //    Prestation p3 = new Prestation("P3", new DateTime(2015, 9, 12, 13, 0, 0), new Intervenant("Auteuil", "Daniel"));
        //    unDossier.AjoutePrestation(p1);
        //    unDossier.AjoutePrestation(p2);
        //    unDossier.AjoutePrestation(p3);
        //    Assert.AreEqual(3, unDossier.GetNbJoursSoinsV2());
        //}

        //[TestMethod]
        //public void TesteNbJoursSoinsV3()
        //{
        //    List<Prestation> listePrestations = new List<Prestation>();
        //    Dossier unDossier = new Dossier("L'asticot", "Toto", new DateTime(1980, 12, 3), new DateTime(2009, 07, 1), listePrestations);
        //    Prestation p1 = new Prestation("P1", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
        //    Prestation p2 = new Prestation("P2", new DateTime(2015, 9, 11, 13, 0, 0), new Intervenant("Bellemare", "Pierre"));
        //    Prestation p3 = new Prestation("P3", new DateTime(2015, 9, 12, 14, 0, 0), new Intervenant("Auteuil", "Daniel"));
        //    Prestation p4 = new Prestation("P4", new DateTime(2015, 9, 13, 15, 0, 0), new Intervenant("Dujardin", "Jean"));
        //    unDossier.AjoutePrestation(p1);
        //    unDossier.AjoutePrestation(p2);
        //    unDossier.AjoutePrestation(p3);
        //    unDossier.AjoutePrestation(p4);
        //    Assert.AreEqual(4, unDossier.GetNbJoursSoinsV3());
        //}
    }
}
