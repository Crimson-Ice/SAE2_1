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
        /// insére les arrets crée la table arret
        /// </summary>
        public static void Insert_Create_Arret_in_tab_arret()
        {
            connection();
            foreach (string arret in ClassStockage.arretCree)
            {
                RequeteSQl($"INSERT INTO Arret (nom_arret,nb_ligne_desservi) VALUES('{arret}', 1);");

                CommandeExecute();
            }
            CloseConnexion();
        }

        /// <summary>
        /// Reccupère tous les id des arret de la ligne crée
        /// </summary>
        /// <returns></returns>
        public static List<string> getAll_id_arret()
        {
            connection();
            List<string> arret = new List<string>();

            RequeteSQl($"select * from Arret;");

            Reading();

            while (ISread())
            {
                foreach ((string, string) c in ClassStockage.listArret)
                {
                    if (c.Item1 == Attribut(1))
                    {
                        arret.Add(Attribut(0));
                    }
                }

            }

            CloseConnexion();
            return arret;
        }

        /// <summary>
        /// insére les id arret dans la table ligne
        /// </summary>
        /// <param name="txt_NomLigneCree"></param>
        /// <param name="arret_intervalle"></param>
        public static void Insert_id_in_tab_ligne(string txt_NomLigneCree, List<string> arret_intervalle)
        {
            connection();

            RequeteSQl($"INSERT INTO Ligne (nom_ligne,nb_arret,id_arret_depart,id_arret_fin) VALUES('{txt_NomLigneCree}',{ClassStockage.listArret.Count},{arret_intervalle[0]},{arret_intervalle[arret_intervalle.Count - 1]});");

            CommandeExecute();

            CloseConnexion();
        }

        /// <summary>
        /// Récuppère l'id de la ligne crée
        /// </summary>
        /// <param name="txt_NomLigneCree"></param>
        public static int get_id_ligne(string txt_NomLigneCree)
        {
            int id_ligne = 0;
            connection();
            //Récuppère l'id de la ligne crée
            RequeteSQl("select * from Ligne;");

            Reading();

            while (ISread())
            {
                if (Attribut(1) == txt_NomLigneCree)
                {
                    id_ligne = int.Parse(Attribut(0)); //mysqlread.GetInt32(0);
                }
            }
            CloseConnexion();

            return id_ligne;
        }

        /// <summary>
        /// insére tout les donnée recuppérer dans la table correspondance
        /// </summary>
        /// <param name="id_ligne"></param>
        /// <param name="arret_intervalle"></param>
        public static void insert_data_in_tab_correspondance(int id_ligne, List<string> arret_intervalle)
        {
            connection();

            for (int i = 0; i < ClassStockage.listArret.Count; i++)
            {
                RequeteSQl($"INSERT INTO Correspondance (id_arret,id_ligne,rang_arret_ligne,heure_premier_bus,heure_dernier_bus) VALUES({arret_intervalle[i]},{id_ligne},{i + 1},'{ClassStockage.listArret[i].Item2}','20:21');");

                CommandeExecute();

            }
            CloseConnexion();
        }
    }
}
