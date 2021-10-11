//-----------------------------------------------------------------------
// <copyright file="Dossier.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CabinetMedical.ClassesMetier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CabinetMedical.Exceptions;

    /// <summary>
    /// Classe Dossier.
    /// </summary>
    public class Dossier
    {
        private string nom;
        private string prenom;
        private DateTime dateNaissance;
        private List<Prestation> listePrestations;
        private DateTime dateCreation;

        /// <summary>
        /// Initializes a new instance of the <see cref="Dossier"/> class.
        /// </summary>
        /// <param name="nom">Nom de la personne à qui correspond le dossier.</param>
        /// <param name="prenom">Prénom de la personne à qui correspond le dossier.</param>
        /// <param name="dateNaissance">Date de naissance de la personne à qui correspond le dossier.</param>
        public Dossier(string nom, string prenom, DateTime dateNaissance)
        {
            this.nom = nom;
            this.prenom = prenom;
            if (dateNaissance.Date.CompareTo(DateTime.Now.Date) <= 0)
            {
                this.dateNaissance = dateNaissance;
            }
            else
            {
                throw new CabinetMedicalException("La date de naissance ne peut pas être supérieure à la date du jour");
            }

            this.listePrestations = new List<Prestation>();
            this.dateCreation = new DateTime(1990, 12, 25);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dossier"/> class.
        /// </summary>
        /// <param name="nom">Nom de la personne à qui correspond le dossier.</param>
        /// <param name="prenom">Prénom de la personne à qui correspond le dossier.</param>
        /// <param name="dateNaissance">Date de naissance de la personne à qui correspond le dossier.</param>
        /// <param name="dateCreation">Date de création du dossier.</param>
        public Dossier(string nom, string prenom, DateTime dateNaissance, DateTime dateCreation)
            : this(nom, prenom, dateNaissance)
        {
            if (dateCreation.Date.CompareTo(DateTime.Now.Date) <= 0)
            {
                this.dateCreation = dateCreation;
            }
            else
            {
                throw new CabinetMedicalException("Date de création non valide");
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dossier"/> class.
        /// </summary>
        /// <param name="nom">Nom de la personne à qui correspond le dossier.</param>
        /// <param name="prenom">Prénom de la personne à qui correspond le dossier.</param>
        /// <param name="dateNaissance">Date de naissance de la personne à qui correspond le dossier.</param>
        /// <param name="dateCreation">Date de création du dossier.</param>
        /// <param name="prestation">La prestation associée au dossier.</param>
        public Dossier(string nom, string prenom, DateTime dateNaissance, DateTime dateCreation, Prestation prestation)
            : this(nom, prenom, dateNaissance)
        {
            if (dateCreation.Date.CompareTo(DateTime.Now.Date) <= 0)
            {
                this.dateCreation = dateCreation;
            }
            else
            {
                throw new CabinetMedicalException("Date de création non valide");
            }

            this.AjoutePrestation(prestation);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dossier"/> class.
        /// </summary>
        /// <param name="nom">Nom de la personne à qui correspond le dossier.</param>
        /// <param name="prenom">Prénom de la personne à qui correspond le dossier.</param>
        /// <param name="dateNaissance">Date de naissance de la personne à qui correspond le dossier.</param>
        /// <param name="dateCreation">Date de création du dossier.</param>
        /// <param name="listePrestations">Liste de prestations associée au dossier.</param>
        public Dossier(string nom, string prenom, DateTime dateNaissance, DateTime dateCreation, List<Prestation> listePrestations)
            : this(nom, prenom, dateNaissance)
        {
            if (dateCreation.Date.CompareTo(DateTime.Now.Date) <= 0)
            {
                this.dateCreation = dateCreation;
            }
            else
            {
                throw new CabinetMedicalException("Date de création non valide");
            }

            this.listePrestations = listePrestations;
        }

        /// <summary>
        /// Gets.
        /// </summary>
        public string Nom { get => this.nom; }

        /// <summary>
        /// Gets.
        /// </summary>
        public string Prenom { get => this.prenom; }

        /// <summary>
        /// Gets.
        /// </summary>
        public DateTime DateNaissance { get => this.dateNaissance; }

        /// <summary>
        /// Gets.
        /// </summary>
        public DateTime DateCreation { get => this.dateCreation; }

        /// <summary>
        /// Ajoute une prestation passée à l'aide de ses attributs en paramètre à une liste de prestations.
        /// </summary>
        /// <param name="p">Objet prestation passée en paramètre.</param>
        public void AjoutePrestation(Prestation p)
        {
            if (p.DateHeureSoin.Date.CompareTo(this.DateCreation.Date) >= 0)
            {
                this.listePrestations.Add(p);
            }
            else
            {
                throw new CabinetMedicalException("La date de prestation doit être postérieure à la date de création du dossier");
            }
        }

        /// <summary>
        /// Permet d'obtenir le nombre de prestations externes.
        /// </summary>
        /// <returns>Retourne le nombre de prestations externes sous la forme d'un entier.</returns>
        public int GetNbPrestationsExternes()
        {
           int cpt = 0;
           foreach (Prestation prestation in this.listePrestations)
            {
                if (prestation.Intervenant is IntervenantExterne)
                {
                    cpt++;
                }
            }

           return cpt;
        }

        /// <summary>
        /// Permet d'obtenir le nombre de prestations.
        /// </summary>
        /// <returns>Retourne le nombre de prestations en entier.</returns>
        public int GetNbPrestations()
        {
            return this.listePrestations.Count;
        }

        /// <summary>
        /// Permet d'obtenir le nombre de jours de prestations version 1.
        /// </summary>
        /// <returns>Retourne le nombre de jours de prestations sous la forme d'un entier.</returns>
        public int GetNbJoursSoinsV1()
        {
            int nb = this.listePrestations.Count;
            for (int i = 0; i < this.listePrestations.Count - 1; i++)
            {
                for (int j = i + 1; j < this.listePrestations.Count; j++)
                {
                    if (Prestation.CompareTo(this.listePrestations[i], this.listePrestations[j]) == 0)
                    {
                        nb--;
                    }
                }
            }

            return nb;
        }

        /// <summary>
        /// Permet d'obtenir le nombre de jours de prestations version 2.
        /// </summary>
        /// <returns>Retourne le nombre de jours de prestations sous la forme d'un entier.</returns>
        public int GetNbJoursSoinsV2()
        {
            List<DateTime> dates = new List<DateTime>();
            foreach (Prestation p in this.listePrestations)
            {
                if (!dates.Contains(p.DateHeureSoin.Date))
                {
                    dates.Add(p.DateHeureSoin.Date);
                }
            }

            return dates.Count;
        }

        /// <summary>
        /// Permet d'obtenir le nombre de jours de prestations version 3.
        /// </summary>
        /// <returns>Retourne le nombre de jours de prestations sous la forme d'un entier.</returns>
        public int GetNbJoursSoinsV3()
        {
           List<Prestation> listeTriee = this.listePrestations.OrderBy(p => p.DateHeureSoin.Date).ToList();

           DateTime comparatif = listeTriee[0].DateHeureSoin.Date;
           int cpt = 1;
           foreach (Prestation p in listeTriee)
            {
                if (comparatif != p.DateHeureSoin.Date)
                {
                    cpt++;
                    comparatif = p.DateHeureSoin.Date;
                }
            }

           return cpt;
        }

        /// <summary>
        /// Convertit un objet en sa représentation sous forme de chaîne afin qu’il soit adapté à l’affichage.
        /// </summary>
        /// <returns>Retourne une chaîne qui représente l'objet actuel.</returns>
        public override string ToString()
        {
            Console.WriteLine("-----Début Dossier--------------");
            string s = "\n Nom : " + this.Nom + " Prenom : " + this.Prenom + " Date de naissance : " + this.DateNaissance;

            foreach (Prestation prestation in this.listePrestations)
            {
                s += prestation;
            }

            return s;
        }
    }
}
