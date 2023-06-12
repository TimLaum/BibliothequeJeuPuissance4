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
        /// <summary>
        /// Variable qui récupère les données du Form qui a affiché celui-ci
        /// </summary>
        FormParametrage frmParam;

        /// <summary>
        /// Variable qui determine par défaut la couleur du joueur1 en Rouge
        /// </summary>
        string colorJ1 = "Rouge";

        /// <summary>
        /// Variable qui determine par défaut la couleur du joueur2 en Jaune
        /// </summary>
        string colorJ2IA = "Jaune";

        /// <summary>
        /// Variable qui determine par défaut le nombre de lignes du plateau a 6
        /// </summary>
        int ligne = 6;

        /// <summary>
        /// Variable qui determine par défaut le nombre de colonnes du plateau a 7
        /// </summary>
        int colonne = 7;

        /// <summary>
        /// Variable qui determine par défaut le joueur qui débute la partie par le joueur1
        /// </summary>
        int JoueurDebutant = 1;

        /// <summary>
        /// Variable qui determine si le Form doit être fermé ou si l'application doit être quittée
        /// </summary>
        bool exit;

        /// <summary>
        /// Variable qui est appelée pour utiliser la fonction Random
        /// </summary>
        Random rnd = new Random();

        /// <summary>
        /// Variable qui est appelée pour utiliser la classe Partie
        /// </summary>
        public Partie Jeu;

        /// <summary>
        /// Variable qui est appelée pour utiliser la classe Joueur et liée au joueur 1
        /// </summary>
        public Joueur Joueur1;

        /// <summary>
        /// Variable qui est appelée pour utiliser la classe Joueur et liée au joueur 2
        /// </summary>
        public Joueur Joueur2IA;


        public FormPartiePerso()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Méthode lors du chargement du Form qui instancie des variables
        /// </summary>
        /// <returns></returns>
        private void FormPartiePerso_Load(object sender, EventArgs e)
        {
            frmParam = (FormParametrage)this.Owner;
            exit = true;
            if (frmParam.type_form)
            {
                rbnIA.Checked = true;
            }

        }

        /// <summary>
        /// Méthode qui ferme l'application si exit = true et que le Form est fermé, sinon ferme juste le Form
        /// </summary>
        /// <returns></returns>
        private void FormPartiePerso_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (exit == true)
                Environment.Exit(0);
        }

        /// <summary>
        /// Méthode qui échange quel radio bouton est pressé si il y a un changement pour qu'il n'y en ai pas deux de pressés
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Méthode qui instancie toutes les données nécessaires au jeu et lance le Form de la partie voulue 
        /// </summary>
        /// <returns></returns>
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
                    FormPartie9x9 newPartie = new FormPartie9x9();
                    this.Hide();
                    newPartie.ShowDialog(this);
                }
                this.Show();

            }

        }

        /// <summary>
        /// Méthode qui instancie les nombres de lignes et colonnes du plateau de jeu selon quel radio bouton est pressé
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Méthode qui instancie le joueur débutant le jeu selon quel radio bouton est pressé
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Méthode qui instancie la couleur des pions des joueurs selon quel radio bouton est pressé
        /// </summary>
        /// <returns></returns>
        private void rbnCouleur_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnRJ.Checked)
            {
                colorJ1 = "Rouge";
                colorJ2IA = "Jaune";
            }
            else if (rbnNR.Checked)
            {
                colorJ1 = "Noir";
                colorJ2IA = "Rouge";
            }
            else if (rbnJN.Checked)
            {
                colorJ1 = "Jaune";
                colorJ2IA = "Noir";
            }
        }

        /// <summary>
        /// Méthode qui retourne au Form précédent lorsque pressé
        /// </summary>
        /// <returns></returns>
        private void btnRetour_Click(object sender, EventArgs e)
        {
            exit = false;
            this.Close();
        }
    }
}
