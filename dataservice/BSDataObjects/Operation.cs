using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.BSDataObjects
{
    public class Operation
    {
        private long reference;
        private string libelle;
        private DateTime dateComptable;
        private DateTime dateOperation;
        private DateTime dateValeur;
        private decimal montantDebit;
        private decimal montantCredit;
        private string statut;
        private Compte compte;
        private string typeOperation;

        public string TypeOperation
        {
            get { return typeOperation; }
            set { typeOperation = value; }
        }


        public long Reference
        {
            get { return reference; }
            set { reference = value; }
        }
        

        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }
        

        public DateTime DateComptable
        {
            get { return dateComptable; }
            set { dateComptable = value; }
        }
        

        public DateTime DateOperation
        {
            get { return dateOperation; }
            set { dateOperation = value; }
        }
        

        public DateTime DateValeur
        {
            get { return dateValeur; }
            set { dateValeur = value; }
        }
        

        public decimal MontantDebit
        {
            get { return montantDebit; }
            set { montantDebit = value; }
        }
        

        public decimal MontantCredit
        {
            get { return montantCredit; }
            set { montantCredit = value; }
        }
        

        public string Statut
        {
            get { return statut; }
            set { statut = value; }
        }
        

        public Compte Compte
        {
            get { return compte; }
            set { compte = value; }
        }


        public Operation() { }

        public override bool Equals(object obj)
        {
            bool b = true;

            if (obj == null)
            {
                b = false;
            }
            else if (!(obj is Operation))
            {
                b = false;
            }
            else
            {
                if ((((Operation)obj).Reference == this.Reference) &&
                    (((Operation)obj).Compte.NumeroCompte.Equals(this.Compte.NumeroCompte))
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
            StringBuilder chaine = new StringBuilder("Détail opération ");
            chaine.Append("Référence : " + this.Reference);
            chaine.Append("Compte concerné : " + this.Compte.NumeroCompte);

            return chaine.ToString();
        }
    }
}