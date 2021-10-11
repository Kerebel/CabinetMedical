//-----------------------------------------------------------------------
// <copyright file="Intervenant.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CabinetMedical.ClassesMetier
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Classe Intervenant.
    /// </summary>
    public class Intervenant
    {
        private string nom;
        private string prenom;
        private List<Prestation> listePrestations = new List<Prestation>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Intervenant"/> class.
        /// </summary>
        /// <param name="nom">Nom de l'intervenant.</param>
        /// <param name="prenom">Prénom de l'intervenant.</param>
        public Intervenant(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
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
        /// Ajoute une prestation passée à l'aide de ses attributs en paramètre à une liste de prestations.
        /// </summary>
        /// <param name="p">Objet prestation ajoutée à la liste.</param>
        public void AjoutePrestation(Prestation p)
        {
            this.listePrestations.Add(p);
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
        /// Convertit un objet en sa représentation sous forme de chaîne afin qu’il soit adapté à l’affichage.
        /// </summary>
        /// <returns>Retourne une chaîne qui représente l'objet actuel.</returns>
        public override string ToString()
        {
            return this.nom + "- " + this.prenom;
        }
    }
}
