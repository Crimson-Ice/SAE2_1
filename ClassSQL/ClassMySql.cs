using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

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
        public static void Connection()
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
        public static List<string> Stockage_arret_existant()
        {
            List<string> stock_arret = new List<string>();

            Connection();

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
            Connection();
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
        public static List<string> GetAll_id_arret()
        {
            List<string> arret = new List<string>();

            foreach ((string, string) c in ClassStockage.listArret)
            {
                arret.Add(Get_id_arret(c.Item1).ToString());
            }

            return arret;
        }

        public static int Get_id_arret(string name_arret)
        {
            Connection();

            RequeteSQl($"select * from Arret;");

            Reading();

            while (ISread())
            {
                if (name_arret == Attribut(1))
                {
                    return int.Parse(Attribut(0));
                }
            }

            CloseConnexion();
            return -1;
        }

        /// <summary>
        /// insére les id arret(debut, fin) dans la table ligne
        /// </summary>
        /// <param name="txt_NomLigneCree"></param>
        /// <param name="arret_intervalle"></param>
        public static void Insert_id_in_tab_ligne(string txt_NomLigneCree, List<string> arret_intervalle)
        {
            Connection();

            RequeteSQl($"INSERT INTO Ligne (nom_ligne,nb_arret,id_arret_depart,id_arret_fin) VALUES('{txt_NomLigneCree}',{ClassStockage.listArret.Count},{arret_intervalle[0]},{arret_intervalle[arret_intervalle.Count - 1]});");

            CommandeExecute();

            CloseConnexion();
        }

        /// <summary>
        /// Récuppère l'id de la ligne crée
        /// </summary>
        /// <param name="txt_NomLigneCree"></param>
        public static int Get_id_ligne(string txt_NomLigneCree)
        {
            int id_ligne = 0;
            Connection();
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
            Connection();

            for (int i = 0; i < ClassStockage.listArret.Count; i++)
            {
                RequeteSQl($"INSERT INTO Correspondance (id_arret,id_ligne,rang_arret_ligne,heure_premier_bus,heure_dernier_bus) VALUES({arret_intervalle[i]},{id_ligne},{i + 1},'{ClassStockage.listArret[i].Item2}','20:21');");
                CommandeExecute();

            }
            CloseConnexion();
        }

        /// <summary>
        /// recupère les noms des lignes dans une liste
        /// </summary>
        /// <returns>Liste de chaine caractère qui contient le noms des lignes</returns>
        public static List<string> Get_ligne_name()
        {
            List<string> ligne_name = new List<string>();

            Connection();

            RequeteSQl("select nom_ligne from Ligne");

            Reading();

            while (ISread())
            {
                ligne_name.Add(Attribut(0));
            }

            CloseConnexion();

            return ligne_name;
        }

        /// <summary>
        /// Ajoute tous les arrets de la ligne a une liste
        /// </summary>
        public static List<string> Liste_arret(string ligne_name)
        {
            List<string> arret = new List<string>();
            Connection();
            RequeteSQl("select Arret.nom_arret from Correspondance,Ligne,Arret where Correspondance.id_ligne = Ligne.id_ligne and Correspondance.id_arret = Arret.id_arret and Ligne.nom_ligne =" + '\u0022' + ligne_name + '\u0022' + " order by rang_arret_ligne;");

            Reading();

            while (ISread())
            {
                string nom = Attribut(0);
                arret.Add(nom);
            }

            return arret;
        }

        /// <summary>
        /// suppprime les arret de correspondance qui l'id correspondant
        /// </summary>
        /// <param name="id">id de la ligne des arrets des arrets a supprimer</param>
        public static void Delete_from_cresspondance(int id)
        {
            Connection();

            RequeteSQl($"delete from Correspondance where id_ligne = '{id}';");
            Reading();

            while (ISread())
            {
            }

            CloseConnexion();
        }

        /// <summary>
        /// suppprime la ligne de la table ligne avec l'id correspondant
        /// </summary>
        /// <param name="id">id de la ligne a suprimer</param>
        public static void Delete_from_Ligne(int id)
        {
            Connection();

            RequeteSQl($"delete from Ligne where id_ligne = '{id}';");

            Reading();
            while (ISread())
            {
            }

            CloseConnexion();
        }

        public static List<(string,string)> get_arretName_and_Firstbus(string ligne_name)
        {
            List<(string,string)> arret_firstBus = new List<(string,string)>();

            Connection();

            RequeteSQl("select Arret.nom_arret,heure_premier_bus from Correspondance,Ligne,Arret where Correspondance.id_ligne = Ligne.id_ligne and Correspondance.id_arret = Arret.id_arret and Ligne.nom_ligne =" + '\u0022' + ligne_name + '\u0022' + " order by rang_arret_ligne;");

            Reading();

            while (ISread())
            {
                arret_firstBus.Add((Attribut(0), Attribut(1)));
            }

            return arret_firstBus;
        }

        /// <summary>
        /// Change le nom d'une ligne
        /// </summary>
        /// <param name="new_name">nouveaux nom</param>
        /// <param name="actual_name">nom actuelle</param>
        public static void change_ligne_name(string new_name, string actual_name)
        {
            Connection();

            RequeteSQl($"UPDATE Ligne SET nom_ligne = '{new_name} ' WHERE nom_ligne = '{actual_name} '; ");

            CommandeExecute();

            CloseConnexion();
        }
    }
}
