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
    public partial class FenPrincipale : Form
    {
        private Utilisateur monCompte;

        public Utilisateur MonCompte
        {
            get { return monCompte; }
            set { monCompte = value; }
        }
       
        public FenPrincipale()
        {
            InitializeComponent();
            InitialisationReferentiel();
        }

        private void InitialisationReferentiel()
        {
            //A remplir
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void auteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ce logiciel a été développé par l'équipe MIDO Paris Dauphine \nAvec la participation de M. Alexis ONGAGNA\nAucours de l'année académique 2014 - 2015", "A propos des auteurs", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FenPrincipale_Load(object sender, EventArgs e)
        {
            FenConnexion connexion = new FenConnexion();
            connexion.ShowDialog(this);
            if (connexion.MonCompte != null)
            {
                this.MonCompte = connexion.MonCompte;
            }
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LCP Gestionnaire Clientèle\nV1.0.0.2015\nRelease du 12/04/2015", "Version", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void monProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FenMonProfil monProfile = new FenMonProfil(this.MonCompte);
            monProfile.ShowDialog(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }             
    }
}
