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
        FormParametrage frmParam;
        string colorJ1 = "Rouge";
        string colorJ2IA = "Jaune";
        int ligne = 6;
        int colonne = 7;
        int JoueurDebutant = 1;
        bool exit;
        Random rnd = new Random();
        public Partie Jeu;
        public Joueur Joueur1;
        public Joueur Joueur2IA;


        public FormPartiePerso()
        {
            InitializeComponent();
        }

        private void FormPartiePerso_Load(object sender, EventArgs e)
        {
            frmParam = (FormParametrage)this.Owner;
            exit = true;
            if (frmParam.type_form)
            {
                rbnIA.Checked=true;
            }

        }

        private void FormPartiePerso_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (exit == true)
                Environment.Exit(0);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnIA.Checked)
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
            if (txbJ1.TextLength == 0 || (txbJ2.Enabled == true && txbJ2.TextLength == 0) || txbJ1.TextLength == 0 && txbJ2.Enabled == false)
            {
                MessageBox.Show("Veuillez-rentrer toutes les informations nécessaires !", "Manque d'informations",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Question);
            }
            else
            {
                Joueur1 = new Joueur(1, colorJ1, txbJ1.Text);
                Joueur2IA = new Joueur(2, colorJ2IA, (txbJ2.Enabled == true ? txbJ2.Text : "IA"));
                Label lblPseudoJoueur = new Label();
                Jeu = new Partie(ligne, colonne, JoueurDebutant);

                if (rbn6x7.Checked)
                {
                    FormPartie6x7 newPartie = new FormPartie6x7();
                    this.Hide();
                    newPartie.ShowDialog(this);
                }
                else if (rbn8x8.Checked)
                {
                    FormPartie8x8 newPartie = new FormPartie8x8();
                    this.Hide();
                    newPartie.ShowDialog(this);
                }
                else
                {
                    FormPartie6x7 newPartie = new FormPartie6x7();
                    this.Hide();
                    newPartie.ShowDialog(this);
                }
                exit = false;
                this.Close();
                //lblPseudoJoueur.Text = Convert.ToString(Joueur1.GetCouleur());
                //MessageBox.Show(Convert.ToString(JoueurDebutant));
            }

        }

        private void rbn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbn6x7.Checked)
            {
                ligne = 6;
                colonne = 7;
            }
            else if (rbn8x8.Checked)
            {
                ligne = 8;
                colonne = 8;
            }
            else
            {
                ligne = 9;
                colonne = 9;
            }
        }

        private void rbnQuiDebute(object sender, EventArgs e)
        {
            if (rbnJ1.Checked)
            {
                JoueurDebutant = 1;
            }
            else if (rbnJ2IA.Checked)
            {
                JoueurDebutant = 2;
            }
            else if (rbnRandom.Checked)
            {
                JoueurDebutant = rnd.Next(1, 3);
            }
        }

        private void rbnCouleur_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnRJ.Checked)
            {
                colorJ1 = "Rouge";
                colorJ2IA = "Jaune";
            }
            else if (rbnRN.Checked)
            {
                colorJ1 = "Rouge";
                colorJ2IA = "Noir";
            }
            else if (rbnBN.Checked)
            {
                colorJ1 = "Jaune";
                colorJ2IA = "Noir";
            }
        }
    }
}
