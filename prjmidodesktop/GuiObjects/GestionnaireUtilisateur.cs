using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Collections;

namespace DesktopIHM.GuiObjects
{
    public class GestionnaireUtilisateur
    {
        public static bool UtilisateurExtiste(string login, string password)
        {
            bool trouver = false;

            IList<Utilisateur> liste = new List<Utilisateur>();

            //Chargement du fichier clients.xml
            XDocument fic = XDocument.Load("XMLFile/Utilisateurs.xml");

            //Sélection d'un utilisateur
            var util = from i in fic.Elements("users").Elements("user")
                       where (string)i.Element("login") == login
                          && (string)i.Element("passwd") == password
                       select new Utilisateur
                       (
                          (string)i.Element("login"),
                          (string)i.Element("passwd"),
                          (string)i.Element("email"),
                          (string)i.Element("profile")
                      );

            IEnumerator enumuser = util.GetEnumerator();

            while (enumuser.MoveNext())
                liste.Add((Utilisateur)enumuser.Current);

            if (liste.Count == 1)
            {
                trouver = true;
            }

            return trouver;
        }

        public static Utilisateur DetailCompte(string login, string password)
        {
            Utilisateur unCompte = null;

            //Chargement du fichier clients.xml
            XDocument fic = XDocument.Load("XMLFile/Utilisateurs.xml");

            //Sélection d'un utilisateur
            var util = from i in fic.Elements("users").Elements("user")
                       where (string)i.Element("login") == login
                          && (string)i.Element("passwd") == password
                       select new Utilisateur
                       (
                          (string)i.Element("login"),
                          (string)i.Element("passwd"),
                          (string)i.Element("email"),
                          (string)i.Element("profile")
                      );

            IEnumerator enumuser = util.GetEnumerator();

            while (enumuser.MoveNext())
                unCompte = (Utilisateur)enumuser.Current;

            return unCompte;
        }

        public static IList<Utilisateur> ListeUtilisateurs()
        {
            IList<Utilisateur> maListe = new List<Utilisateur>();

            //Chargement du fichier clients.xml
            XDocument fic = XDocument.Load("XMLFile/Utilisateurs.xml");

            //Sélection d'un utilisateur
            var util = from i in fic.Elements("users").Elements("user")                       
                       select new Utilisateur
                       (
                          (string)i.Element("login"),
                          (string)i.Element("passwd"),
                          (string)i.Element("email"),
                          (string)i.Element("profile")
                      );

            IEnumerator enumuser = util.GetEnumerator();

            while (enumuser.MoveNext())
                maListe.Add((Utilisateur)enumuser.Current);

            return maListe;
        }
    }
}
