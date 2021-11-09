namespace CabinetMedical.ClassesMetier
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using CabinetMedical.Exceptions;

    public class Cotation
    {
        private string id;
        private string libelle;
        private int indice;

        public Cotation(string id, string libelle, int indice)
        {
            this.id = id;
            this.libelle = libelle;
            if (indice > 0)
            {
                this.indice = indice;
            }
            else
            {
                throw new CabinetMedicalException("L'indice ne peut pas être négatif ou nul");
            }
        }

        public string Id { get => id; }

        public string Libelle { get => libelle; set => libelle = value; }

        public int Indice { get => indice; set => indice = value; }
    }
}
