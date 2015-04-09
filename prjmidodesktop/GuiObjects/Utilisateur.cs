using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopIHM.GuiObjects
{
    public class Utilisateur
    {
        private string login;
        private string password;
        private string email;
        private string profile;


        public string Email
        {
            get { return email; }
            set { email = value; }
        }        

        public string Profile
        {
            get { return profile; }
            set { profile = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Utilisateur(string _login, string _password, string _email, string _profile)
        {
            this.login = _login;
            this.password = _password;
            this.email = _email;
            this.profile = _profile;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else
            {
                if (obj is Utilisateur)
                {
                    Utilisateur util = (Utilisateur)obj;
                    return (this.Login.Equals(util.Login) && this.Password.Equals(util.Password));
                }                
            }
            return false;
        }

        public override string ToString()
        {
            return "Utilisateur "+this.login+" / Password : "+this.Password;
        }
    }
}
