using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DesktopIHM.GuiObjects;

namespace DesktopIHM
{
    public partial class FenConnexion : Form
    {
        private Utilisateur monCompte;

        public Utilisateur MonCompte
        {
            get { return monCompte; }
            set { monCompte = value; }
        }

        public FenConnexion()
        {
            InitializeComponent();
        }

        public FenConnexion(Utilisateur user)
        {
            InitializeComponent();
            monCompte = user;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Owner.Dispose();
            this.Close();
        }

        private void seconnecter_Click(object sender, EventArgs e)
        {
            string _login = txtLogin.Text;
            string _pwd = txtPassword.Text;



            bool trouver = GestionnaireUtilisateur.UtilisateurExtiste(_login, _pwd);

            if (trouver)
            {
                this.MonCompte = GestionnaireUtilisateur.DetailCompte(_login, _pwd);
                this.Close();
            }
            else
                MessageBox.Show("Erreur d'identification. Reessayez", "Echec de connexion", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }       
    }
}
