using System.Collections.Generic;
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
            connexion.Open();
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
        /// Execute une commande Sql sans reader
        /// </summary>
        public static void CommandeExecute()
        {
            mysqlcom.ExecuteNonQuery();
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


        /// <summary>
        /// Remplie une liste de chaine de caractère avec le nom de tout les arrêts existant dans la base de donnée
        /// </summary>
        /// <returns>revoie une liste de chaine de caratère</returns>
        public static List<string> stockage_arret_existant()
        {
            List<string> stock_arret = new List<string>();

            connection();

            RequeteSQl("select * from Arret");

            Reading();

            while (ISread())
            {
                stock_arret.Add(Attribut(1));
            }

            CloseConnexion();

            return stock_arret;
        }

        /// <summary>
        /// insére les arrets crée dans la base de donnée
        /// </summary>
        public static void Insert_Create_Arret()
        {
            connection();
            foreach (string arret in ClassStockage.arretCree)
            {
                RequeteSQl($"INSERT INTO Arret (nom_arret,nb_ligne_desservi) VALUES('{arret}', 1);");

                CommandeExecute();
            }
            CloseConnexion();
        }
    }
}
