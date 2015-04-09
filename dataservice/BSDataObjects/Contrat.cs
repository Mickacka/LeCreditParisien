using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.BSDataObjects
{
    public class Contrat
    {
        private long numeroContrat;
        private DateTime dateSouscription;
        private string intitule;
        private Client client;
        private Produit produit;
        private Compte compte;
        private string statutJuridique;

        public long NumeroContrat
        {
            get { return numeroContrat; }
            set { numeroContrat = value; }
        }
        

        public string Intitule
        {
            get { return intitule; }
            set { intitule = value; }
        }
        

        public string StatutJuridique
        {
            get { return statutJuridique; }
            set { statutJuridique = value; }
        }
        
        public DateTime DateSouscription
        {
            get { return dateSouscription; }
            set { dateSouscription = value; }
        }
        
        public Client Client
        {
            get { return client; }
            set { client = value; }
        }
        
        public Produit Produit
        {
            get { return produit; }
            set { produit = value; }
        }
        

        public Compte Compte
        {
            get { return compte; }
            set { compte = value; }
        }

        public Contrat() { }

        public override bool Equals(object obj)
        {
            bool b = true;

            if (obj == null)
            {
                b = false;
            }
            else if (!(obj is Contrat))
            {
                b = false;
            }
            else
            {
                if ((((Contrat)obj).NumeroContrat == this.NumeroContrat) &&
                    (((Compte)obj).Client.Equals(this.Client))
                )
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
            StringBuilder chaine = new StringBuilder("Détail contrat ");
            chaine.Append("Numéro Contrat : " + this.NumeroContrat);
            chaine.Append("Numéro Client : " + this.Client.NumeroClient);

            return chaine.ToString();
        }
    }
}
