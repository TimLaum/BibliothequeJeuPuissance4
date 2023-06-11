using BibliothequeJeuPuissance4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE___Puissance_4
{
    public partial class FormPartie9x9 : Form
    {
        private FormPartiePerso frmPrmPerso;
        private int columnNumber;
        private SoundPlayer JetonPose = new SoundPlayer(Properties.Resources.Son_Placement_Pion);
        public FormPartie9x9()
        {
            InitializeComponent();
        }
        private void FormPartie9x9_Load(object sender, EventArgs e)
        {
            frmPrmPerso = (FormPartiePerso)this.Owner;
            TourDuJoueur();
            Panel_Transparence(pnlC1);
            Panel_Transparence(pnlC2);
            Panel_Transparence(pnlC3);
            Panel_Transparence(pnlC4);
            Panel_Transparence(pnlC5);
            Panel_Transparence(pnlC6);
            Panel_Transparence(pnlC7);
            Panel_Transparence(pnlC8);
            Panel_Transparence(pnlC9);
            playLooping();
        }

        private void Panel_Transparence(Panel p)
        {
            var posi = this.PointToScreen(p.Location);
            posi = picPlateau.PointToClient(posi);
            p.Parent = picPlateau;
            p.Location = posi;
            p.BackColor = Color.FromArgb(0, 0, 0, 0);

        }
        private void playLooping()
        {
            try
            {
                // Note: You may need to change the location specified based on
                // the sounds loaded on your computer.
                SoundPlayer Musique = new SoundPlayer(Properties.Resources.Musique);
                Musique.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error playing sound");
            }
        }

        private void rejouer(bool win, string pseudo)
        {
            if (win)
            {
                DialogResult rejouer = MessageBox.Show($"Victoire du joueur {pseudo}\n\nSouhaitez-vous rejouer?", "Victoire !", MessageBoxButtons.YesNo);
                if (rejouer == DialogResult.Yes)
                    this.Close();
                else
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                DialogResult rejouer = MessageBox.Show($"Égalité des deux joueurs!\n\nSouhaitez-vous rejouer?", "Égalité !", MessageBoxButtons.YesNo);
                if (rejouer == DialogResult.Yes)
                    this.Close();
                else
                {
                    Environment.Exit(0);
                }
            }
        }

        private void ChoixPicCouleurPion(PictureBox pic)
        {
            if (frmPrmPerso.Jeu.GetJoueurActif() == 1)
            {
                string x = frmPrmPerso.Joueur1.GetCouleur();
                if (x == "Rouge")
                {
                    pic.Image = Properties.Resources.PionRougeP8x8;
                }
                if (x == "Jaune")
                {
                    pic.Image = Properties.Resources.PionJauneP8x8;
                }
                if (x == "Noir")
                {
                    pic.Image = Properties.Resources.PionNoirP8x8;
                }
            }
            else
            {
                string x = frmPrmPerso.Joueur2IA.GetCouleur();
                if (x == "Noir")
                {
                    pic.Image = Properties.Resources.PionNoirP8x8;
                }
                if (x == "Jaune")
                {
                    pic.Image = Properties.Resources.PionJauneP8x8;
                }
                if (x == "Rouge")
                {
                    pic.Image = Properties.Resources.PionRougeP8x8;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlC_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;

            // Obtenez le nom du panneau
            string panelName = panel.Name;

            // Supprimez la partie "pnlC" du nom du panneau
            string numericPart = panelName.Replace("pnlC", "");

            // Convertissez la partie numérique en un entier
            columnNumber = int.Parse(numericPart);
            columnNumber = columnNumber - 1;
        }


        private void appelleIA()
        {
            IA JoueurIA = new IA(5, 2);

            int i = 0;
            List<(int, int)> CoupAJouer = new List<(int, int)>();

            CoupAJouer = JoueurIA.MeilleurCoup(frmPrmPerso.Jeu);
            string nomPanel = string.Format("pnlC{0}", CoupAJouer[0].Item2 + 1);
            Panel panel = Controls.Find(nomPanel, true).FirstOrDefault() as Panel;
            ChoixPicCouleurPion((PictureBox)panel.Controls[frmPrmPerso.Jeu.GetLignes() - (CoupAJouer[0].Item1) - 1]);
            JouerUnCoup(CoupAJouer);
            if (frmPrmPerso.Jeu.EstTerminee() == 1)
                rejouer(true, frmPrmPerso.Joueur1.GetPseudoJoueur());
            else if (frmPrmPerso.Jeu.EstTerminee() == 2)
                rejouer(true, frmPrmPerso.Joueur2IA.GetPseudoJoueur());
            else if (frmPrmPerso.Jeu.EstTerminee() == 0)
                rejouer(false, "");
        }

        private void JouerUnCoup(List<(int, int)> CoupAJouer)
        {
            frmPrmPerso.Jeu.JouerCoup(CoupAJouer, frmPrmPerso.Jeu.GetJoueurActif());
            JetonPose.Play();
            JetonPose.Dispose();
            TourDuJoueur();


        }

        private void TourDuJoueur()
        {
            if (frmPrmPerso.Jeu.GetJoueurActif() == 1)
            {
                lblTourJoueur9x9.Text = $"Au tour du joueur : {frmPrmPerso.Joueur1.GetPseudoJoueur()}";
                ChoixPicCouleurPion(picJActuel9x9);
            }
            else
            {
                lblTourJoueur9x9.Text = $"Au tour du joueur : {frmPrmPerso.Joueur2IA.GetPseudoJoueur()}";
                ChoixPicCouleurPion(picJActuel9x9);
            }
        }

        private async void pnlC_Click(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            List<(int, int)> CoupAJouer = new List<(int, int)>();
            int i = frmPrmPerso.Jeu.GetLignes() - 1;
            while (i >= 0)
            {
                if (frmPrmPerso.Jeu.EstPossible(i, columnNumber))
                {
                    CoupAJouer.Add((i, columnNumber));
                    ChoixPicCouleurPion((PictureBox)panel.Controls[frmPrmPerso.Jeu.GetLignes() - 1 - i]);
                    JouerUnCoup(CoupAJouer);
                    if (frmPrmPerso.Jeu.EstTerminee() == 1)
                    {
                        rejouer(true, frmPrmPerso.Joueur1.GetPseudoJoueur());
                        break;

                    }
                    else if (frmPrmPerso.Jeu.EstTerminee() == 2)
                    {
                        rejouer(true, frmPrmPerso.Joueur2IA.GetPseudoJoueur());
                        break;

                    }
                    else if (frmPrmPerso.Jeu.EstTerminee() == 0)
                    {
                        rejouer(false, "");
                        break;
                    }
                    else
                    {
                        if (frmPrmPerso.Joueur2IA.GetPseudoJoueur() == "IA" && frmPrmPerso.Jeu.GetJoueurActif() == frmPrmPerso.Joueur2IA.GetN_Joueur())
                        {
                            await Task.Delay(500);
                            appelleIA();
                        }
                        break;

                    }


                }
                i--;

            }

        }
    }
}
