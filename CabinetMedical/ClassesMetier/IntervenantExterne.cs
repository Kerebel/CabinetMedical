//-----------------------------------------------------------------------
// <copyright file="IntervenantExterne.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace CabinetMedical.ClassesMetier
{
    /// <summary>
    /// Classe Intervenant Externe qui hérite de la classe Intervenant.
    /// </summary>
    public class IntervenantExterne : Intervenant
    {
        private string specialite;
        private string adresse;
        private int tel;

        /// <summary>
        /// Initializes a new instance of the <see cref="IntervenantExterne"/> class.
        /// </summary>
        /// <param name="nom"> Nom de l'intervenant externe.</param>
        /// <param name="prenom">Prénom de l'intevenant externe.</param>
        /// <param name="specialite"> Spécialité de l'intervenant externe.</param>
        /// <param name="adresse">Adresse de l'intervenant externe.</param>
        /// <param name="tel">Numéro de téléphone de l'intervenant externe.</param>
        public IntervenantExterne(string nom, string prenom, string specialite, string adresse, int tel)
            : base(nom, prenom)
        {
            this.Specialite = specialite;
            this.Adresse = adresse;
            this.Tel = tel;
        }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        public string Specialite { get => this.specialite; set => this.specialite = value; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        public string Adresse { get => this.adresse; set => this.adresse = value; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        public int Tel { get => this.tel; set => this.tel = value; }

        /// <summary>
        /// Convertit un objet en sa représentation sous forme de chaîne afin qu’il soit adapté à l’affichage.
        /// </summary>
        /// <returns>Retourne une chaîne qui représente l'objet actuel.</returns>
        public override string ToString()
        {
            return base.ToString() + " Spécialité : " + this.specialite + " " + this.adresse + "- " + this.tel;
        }
    }
}
