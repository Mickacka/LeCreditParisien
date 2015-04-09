using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql;
using MySql.Data.MySqlClient;
using System.Data;
namespace DataService.DAOService
{
    public class GestionBDD
    {
        //Attributs de la classe
        private string hostname;
        private string userid;
        private string password;
        private string databasename;

        //Constructeur
        public GestionBDD(string machine, string schema, string pwd, string bdd)
        {
            hostname = machine;
            userid = schema;
            password = pwd;
            databasename = bdd;
        }

        //Getter et Setter
        public string Hostname
        {
            get { return hostname; }
            set { hostname = value; }
        }

        public string Userid
        {
            get { return userid; }
            set { userid = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Databasename
        {
            get { return databasename; }
            set { databasename = value; }
        }

        //Méthodes d'instance

        //1 - Renvoie une connexion à partir des attributs de la classe
        public MySqlConnection Connection()
        {
            MySqlConnection conn = null;

            try
            {
                MySqlConnectionStringBuilder connectionString = new MySqlConnectionStringBuilder();
                connectionString.Server = Hostname;
                connectionString.UserID = Userid;
                connectionString.Password = Password;
                connectionString.Database = Databasename;

                conn = new MySqlConnection(connectionString.ToString());
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return conn;
        }

        //2 - Affiche la version courante du SGBD MySQL
        public void VersionCouranteSGBD()
        {
            using (MySqlConnection myConn = this.Connection())
            {
                Console.WriteLine("La version du SGBD MySQL est : {0}", myConn.ServerVersion);
            }
        }

        //3 - Affiche la date et l'heure courante du serveur de base de données
        public void DateCouranteSGBD()
        {
            using (MySqlConnection myConn = this.Connection())
            {
                string statement = "SELECT NOW()";
                MySqlCommand cmd = new MySqlCommand(statement, myConn);
                string dateCourante = Convert.ToString(cmd.ExecuteScalar());
                Console.WriteLine("La date et heure courante est : {0}", dateCourante);
            }
        }

        //4 - Affiche la version, la date et l'heure courante et l'utilisateur connecté
        public void InfosCompletesSGBD()
        {
            using (MySqlConnection myConn = this.Connection())
            {
                string statement = "SELECT version(), now(), user()";
                MySqlCommand cmd = new MySqlCommand(statement, myConn);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr.GetString(0) + "\t"
                        + rdr.GetString(1) + "\t"
                        + rdr.GetString(2));
                }
            }
        }

        //5 - Affiche la liste des utilisateurs (les schémas) de la base de données
        public void ListeUtilisateurBDD()
        {
            using (MySqlConnection myConn = this.Connection())
            {
                string statement = "SELECT host, user FROM mysql.user";
                MySqlCommand cmd = new MySqlCommand(statement, myConn);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                    Console.WriteLine(rdr.GetString(0) + "\t" + rdr.GetString(1));
            }
        }

        //6 - Création d'un compte avec attribution des privilèges sur la base de données courante
        public void CreerUtilisateur(string user_name, string password)
        {
            using (MySqlConnection myConn = this.Connection())
            {
                //Création du compte
                StringBuilder statement = new StringBuilder("CREATE USER ");
                statement.Append(user_name);
                statement.Append(" IDENTIFIED BY '");
                statement.Append(password);
                statement.Append("'");
                MySqlCommand cmd = new MySqlCommand(statement.ToString(), myConn);
                cmd.ExecuteNonQuery();

                //Attribution de tous les privilèges sur la base de données
                statement = new StringBuilder("GRANT ALL PRIVILEGES ON ");
                statement.Append(this.Databasename);
                statement.Append(" TO ");
                statement.Append(user_name);
                statement.Append("@");
                statement.Append(this.Hostname);
                statement.Append(" IDENTIFIED BY '");
                statement.Append(password);
                statement.Append("'");
                cmd = new MySqlCommand(statement.ToString(), myConn);
                cmd.ExecuteNonQuery();
            }
        }

        //7 - Affiche la liste des tables disponibles sur la base de données courante
        public void ListeTablesBDD()
        {
            using (MySqlConnection myConn = this.Connection())
            {
                string statement = "SHOW TABLES IN " + this.Databasename;
                MySqlCommand cmd = new MySqlCommand(statement, myConn);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr.GetString(0));
                }
            }
        }

        //8 - Exécute une requete d'insertion non paramétrée. La requête est passée en argument
        public int ExecuteNonParamInsertQuery(string statement)
        {
            int nbLignes = -1;

            using (MySqlConnection myConn = this.Connection())
            {
                if (!statement.Equals(string.Empty))
                {
                    MySqlCommand cmd = new MySqlCommand(statement, myConn);

                    nbLignes = cmd.ExecuteNonQuery();
                }
            }
            return nbLignes;
        }

        //9 - Exécute une requete de selection sur la table passée en argument
        public void ExecuteSelectQuery(string table_name)
        {
            string nom_fichier = table_name + ".xml";
            using (MySqlConnection myConn = this.Connection())
            {
                if (!table_name.Equals(string.Empty))
                {
                    //Déclaration de la DataSet
                    DataSet ds = new DataSet();

                    //Exécution de la requête
                    string stm = "SELECT * FROM " + table_name;
                    MySqlDataAdapter da = new MySqlDataAdapter(stm, myConn);

                    //Remplissage de la dataset avec le résultat de la 1ère requête
                    da.Fill(ds, table_name);

                    DataTable dt = ds.Tables[table_name];
                    dt.WriteXml(nom_fichier);
                }
            }
        }
    }
}
