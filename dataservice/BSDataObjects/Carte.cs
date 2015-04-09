using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.BSDataObjects
{
    public class Carte : MoyenPaiement
    {
        private string numeroCarte;
        private DateTime dateDebValidite;
        private DateTime dateFinValidite;
        private string reseauCarte;
        private TypeCarte typeCarte;

        public string NumeroCarte
        {
            get { return numeroCarte; }
            set { numeroCarte = value; }
        }
        

        public DateTime DateDebValidite
        {
            get { return dateDebValidite; }
            set { dateDebValidite = value; }
        }
        

        public DateTime DateFinValidite
        {
            get { return dateFinValidite; }
            set { dateFinValidite = value; }
        }
        

        public string ReseauCarte
        {
            get { return reseauCarte; }
            set { reseauCarte = value; }
        }
        

        public TypeCarte TypeCarte
        {
            get { return typeCarte; }
            set { typeCarte = value; }
        }

        public Carte() { }

        public override bool Equals(object obj)
        {
            bool b = true;

            if (obj == null)
            {
                b = false;
            }
            else if (!(obj is Carte))
            {
                b = false;
            }
            else
            {
                if ((((Carte)obj).NumeroCarte == this.NumeroCarte))
                {
                    b = true;
                }
                else
                {
                    b = false;
                }
            }
            return b;
        }

        public override string ToString()
        {
            StringBuilder chaine = new StringBuilder("Détail carte ");
            chaine.Append("Référence : " + this.NumeroCarte);            

            return chaine.ToString();
        }
    }
}
