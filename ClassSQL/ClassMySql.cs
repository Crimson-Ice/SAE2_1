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

        public static void connection()
        {
            //création objet connexion 
            connexion = new MySqlConnection("database=baseb1; server=10.1.139.236; user id=b1; pwd=nouveau_mdp");
            
        }
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

        public static void RequeteSQl(string requete)
        {
            //requete sql
            mysqlcom = new MySqlCommand(requete, connexion);
        }

        public static void Reading()
        {
            //lis la requete et recupère les données
            mysqlread = mysqlcom.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public static bool ISread()
        {
            return mysqlread.Read();
        }

        public static string Attribut(int nb)
        {
            return mysqlread.GetString(nb);
        }

        public static void CloseConnexion()
        {
            connexion.Close();
        }
    }
}
