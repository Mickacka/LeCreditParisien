using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.BSDataObjects
{
    public class HistoriqueEtudiant
    {
        private long referenceHistorique;
        private string anneeAcademique;
        private string diplomePrepare;
        private string niveauEtude;
        private Client client;

        public long ReferenceHistorique
        {
            get { return referenceHistorique; }
            set { referenceHistorique = value; }
        }
        

        public string AnneeAcademique
        {
            get { return anneeAcademique; }
            set { anneeAcademique = value; }
        }
        

        public string DiplomePrepare
        {
            get { return diplomePrepare; }
            set { diplomePrepare = value; }
        }
        

        public string NiveauEtude
        {
            get { return niveauEtude; }
            set { niveauEtude = value; }
        }
        

        public Client Client
        {
            get { return client; }
            set { client = value; }
        }

        public HistoriqueEtudiant() { }

        public override bool Equals(object obj)
        {
            bool b = true;

            if (obj == null)
            {
                b = false;
            }
            else if (!(obj is HistoriqueEtudiant))
            {
                b = false;
            }
            else
            {
                if ((((HistoriqueEtudiant)obj).ReferenceHistorique == this.ReferenceHistorique) &&
                    (((HistoriqueEtudiant)obj).Client.Equals(this.Client))
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
            StringBuilder chaine = new StringBuilder("Historique Etudiant ");
            chaine.Append("Référence histo : " + this.ReferenceHistorique);
            chaine.Append("Année académique : "+this.AnneeAcademique);
            chaine.Append("Diplôme préparé : "+this.DiplomePrepare);
            chaine.Append("Niveau d'étude : "+this.NiveauEtude);
            chaine.Append("Client : "+this.Client.ToString());
            
            return chaine.ToString();
        }
    }
}