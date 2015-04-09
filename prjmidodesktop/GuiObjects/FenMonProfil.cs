using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopIHM.GuiObjects
{
    public partial class FenMonProfil : Form
    {
        private Utilisateur compteUtilisateur;

        public Utilisateur CompteUtilisateur
        {
            get { return compteUtilisateur; }
            set { compteUtilisateur = value; }
        }

        public FenMonProfil(Utilisateur user)
        {
            this.CompteUtilisateur = user;
            InitializeComponent();
            InitProfile();
        }

        public void InitProfile()
        {
            if (this.CompteUtilisateur != null)
            {
                this.monLogin.Text = CompteUtilisateur.Login;
                this.monEmail.Text = CompteUtilisateur.Email;
                this.monProfile.Text = CompteUtilisateur.Profile;          
            }
        }
    }
}
