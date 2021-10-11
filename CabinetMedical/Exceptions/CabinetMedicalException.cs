// <copyright file="CabinetMedicalException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CabinetMedical.Exceptions
{
    using System;

    /// <summary>
    /// Exception de la classe CabinetMedicalException.
    /// </summary>
    public class CabinetMedicalException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CabinetMedicalException"/> class.
        /// </summary>
        /// <param name="message">Message de l'exception.</param>
        public CabinetMedicalException(string message)
            : base(message)
        {
            // var erreur = new Dictionary<string, string>
            // {
            //    { "Soins2021", System.Reflection.Assembly.GetExecutingAssembly().GetName().Name.ToString()},
            //    { "ClasseException", GetType().Name.ToString()},
            //    { "DateException", DateTime.Now.ToString()},
            //    { "MessageException", this.Message.ToString()},
            //    { "UserException", Environment.UserName.ToString()},
            //    { "UserMachine", Environment.MachineName.ToString()}
            // };
            ////StructException structException= new StructException()

            // string json = JsonConvert.SerializeObject(erreur, Formatting.Indented);
            // Dictionary<string, string> jsonD = JsonConvert.DeserializeObject<Dictionary<string,string>>(json);

            // fichierJson.Add(erreur);
            // string logJson = JsonConvert.SerializeObject(fichierJson, Formatting.Indented);

            // Recherche FileStream (lire le flux de donnée pour s'arrêter avant le crochet puis ajouter le nouveau contenu)

            // string filePath = @"E:\BTS SIO 2\ROCHE\REVISIONS TP\ExceptionData.json";
            // File.AppendAllText(filePath, logJson);
        }

        // public static void Log ()
        //    {
        //        // string logJson = JsonConvert.SerializeObject(SoinsException.FichierJson, Formatting.Indented);
        //        string logJson = JsonConvert.SerializeObject(this);

        // string filePath = @"E:\BTS SIO 2\ROCHE\REVISIONS TP\ExceptionData.json";
        //        File.AppendAllText(filePath, logJson);
        //        string contenu = File.ReadAllText(filePath);
        //        contenu = contenu.Replace("][", string.Empty);
        //        File.WriteAllText(filePath, contenu);
        //        contenu=contenu.Replace("]", this.J)
        //    }

        // public static ArrayList FichierJson { get => fichierJson;}
        // }
    }
}
