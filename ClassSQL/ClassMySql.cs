using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ClassSQL
{
    public static class ClassMySql
    {
        static MySqlConnection connexion;
        static MySqlCommand mysqlcom;
        static MySqlDataReader mysqlread;

        /// <summary>
        /// Crée un objet connexion
        /// </summary>
        public static void connection()
        {
            connexion = new MySqlConnection("database=baseb1; server=10.1.139.236; user id=b1; pwd=nouveau_mdp");
            mysqlcom = null;
            mysqlread = null;
        }

        /// <summary>
        /// Test la connexion de la base avec l'objet connexion initialement crée
        /// </summary>
        /// <returns>Une chaine de caractère qui donne l'état de la connexion</returns>
        public static string TestConnexion()
        {
            try
            {
                connexion.Open();
                return("connecté");
            }
            catch (MySqlException ex)
            {
                return(ex.Message + " non connecté");
            }
        }

        /// <summary>
        /// Crée une requete Sql
        /// </summary>
        /// <param name="requete">Chaine de caractère de la requete</param>
        public static void RequeteSQl(string requete)
        {
            //requete sql
            mysqlcom = new MySqlCommand(requete, connexion);
        }

        /// <summary>
        /// La requete préalabement donné
        /// </summary>
        public static void Reading()
        {
            //lis la requete et recupère les données
            mysqlread = mysqlcom.ExecuteReader(CommandBehavior.CloseConnection);
        }

        /// <summary>
        /// Check si il reste des données a lire
        /// </summary>
        /// <returns>Un booléen</returns>
        public static bool ISread()
        {
            return mysqlread.Read();
        }

        /// <summary>
        /// Donne un attribut de la ligne actuel
        /// </summary>
        /// <param name="nb">entier qui représente l'attribut de la ligne</param>
        /// <returns>Une chaine caractère </returns>
        public static string Attribut(int nb)
        {
            return mysqlread.GetString(nb);
        }

        /// <summary>
        /// Ferme la connexion
        /// </summary>
        public static void CloseConnexion()
        {
            connexion.Close();
        }
    }
}
