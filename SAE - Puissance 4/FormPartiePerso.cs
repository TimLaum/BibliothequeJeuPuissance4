using BibliothequeJeuPuissance4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE___Puissance_4
{
    public partial class FormPartiePerso : Form
    {
        string colorJ1 = "Rouge";
        string colorJ2IA = "Jaune";
        bool exit;
        public FormPartiePerso()
        {
            InitializeComponent();
        }

        private void FormPartiePerso_Load(object sender, EventArgs e)
        {
            exit = true;
        }

        private void FormPartiePerso_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (exit = true)
                Environment.Exit(0);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                txbJ2.Enabled = false;
            }
            else
            {
                txbJ2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbJ1.TextLength == 0 && (txbJ2.Enabled == true && txbJ2.TextLength == 0) || txbJ1.TextLength == 0 && txbJ2.Enabled == false)
            {
                MessageBox.Show("Veuillez-rentrer toutes les informations nécessaires !", "Manque d'informations",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Question);
            }
            else
            {
                Joueur Joueur1 = new Joueur(1, colorJ1, txbJ1.Text);
                Joueur Joueur2IA = new Joueur(2, colorJ2IA, (txbJ2.Enabled == true ? txbJ2.Text : "IA"));
                Label lblPseudoJoueur = new Label();
                lblPseudoJoueur.Text = Convert.ToString(Joueur1.GetCouleur());
                MessageBox.Show(colorJ1);
            }

        }

        private void rbnRJ_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnRJ.Checked)
            {
                colorJ1 = "Rouge";
                colorJ2IA = "Jaune";
            }
        }

        private void rbnBN_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnBN.Checked)
            {
                colorJ1 = "Blanc";
                colorJ2IA = "Noir";
            }
        }

        private void rbnRN_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnRN.Checked)
            {
                colorJ1 = "Rouge";
                colorJ2IA = "Noir";
            }
        }
    }
}
