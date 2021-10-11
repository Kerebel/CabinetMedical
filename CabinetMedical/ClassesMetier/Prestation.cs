//-----------------------------------------------------------------------
// <copyright file="Prestation.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CabinetMedical.ClassesMetier
{
    using System;
    using CabinetMedical.Exceptions;

    /// <summary>
    /// Classe Prestation.
    /// </summary>
    public class Prestation
    {
        private string libelle;
        private DateTime dateHeureSoin;
        private Intervenant intervenant;

        /// <summary>
        /// Initializes a new instance of the <see cref="Prestation"/> class.
        /// </summary>
        /// <param name="libelle">Libelle de la classe Prestation.</param>
        /// <param name="dateHeureSoin">La date de la prestation.</param>
        public Prestation(string libelle, DateTime dateHeureSoin)
        {
            this.Libelle = libelle;

            // this.dateHeureSoin.Date.CompareTo(DateTime.Now.Date) <= 0
            if (DateTime.Compare(DateTime.Now.Date, dateHeureSoin.Date) >= 0)
            {
                this.dateHeureSoin = dateHeureSoin;
            }
            else
            {
                throw new CabinetMedicalException("La date de prestation ne peut pas être après le jour actuel");
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Prestation"/> class.
        /// </summary>
        /// <param name="libelle">Libelle de la classe Prestation.</param>
        /// <param name="dateHeureSoin">La date de la prestation.</param>
        /// <param name="intervenant">Objet intervenant de la classe Interveant.</param>
        public Prestation(string libelle, DateTime dateHeureSoin, Intervenant intervenant)
            : this(libelle, dateHeureSoin)
        {
            this.intervenant = intervenant;
        }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        public string Libelle { get => this.libelle; set => this.libelle = value; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        public DateTime DateHeureSoin { get => this.dateHeureSoin; set => this.dateHeureSoin = value; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        public Intervenant Intervenant { get => this.intervenant; set => this.intervenant = value; }

        /// <summary>
        /// Permet de comparer deux prestations en fonction de leur date.
        /// </summary>
        /// <param name="a"> 1ère prestation.</param>
        /// <param name="b"> 2ème prestation.</param>
        /// <returns>Retourne moins de 0 si a précède b, 0 si a a la même date que b et plus que 0 si a est après b.</returns>
        public static int CompareTo(Prestation a, Prestation b)
        {
            return DateTime.Compare(a.DateHeureSoin.Date, b.DateHeureSoin.Date);
        }

        /// <summary>
        /// Convertit un objet en sa représentation sous forme de chaîne afin qu’il soit adapté à l’affichage.
        /// </summary>
        /// <returns>Retourne une chaîne qui représente l'objet actuel.</returns>
        public override string ToString()
        {
            return " \n\tLibelle " + this.libelle + " " + this.dateHeureSoin + "- Intervenant : " + this.intervenant;
        }
    }
}
