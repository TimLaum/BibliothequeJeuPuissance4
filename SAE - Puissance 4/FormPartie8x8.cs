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
    public partial class FormPartie8x8 : Form
    {
        private FormPartiePerso frmPrmPerso;
        private int columnNumber;
        public FormPartie8x8()
        {
            InitializeComponent();
        }

        private void FormPartie8x8_Load(object sender, EventArgs e)
        {
            frmPrmPerso = (FormPartiePerso)this.Owner;
            ChoixPicCouleurPion(picJActuel8x8);
            Panel_Transparence(pnlC1);
            Panel_Transparence(pnlC2);
            Panel_Transparence(pnlC3);
            Panel_Transparence(pnlC4);
            Panel_Transparence(pnlC5);
            Panel_Transparence(pnlC6);
            Panel_Transparence(pnlC7);
            Panel_Transparence(pnlC8);
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnlC1_Paint(object sender, PaintEventArgs e)
        {
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

        private void pnlC_Click(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            List<(int, int)> CoupAJouer = new List<(int, int)>();
            int i = 0;
            while (i < frmPrmPerso.Jeu.GetColonnes())
            {
                if (frmPrmPerso.Jeu.GetPion(columnNumber, i) == 0)
                {
                    CoupAJouer.Add((columnNumber, i));
                    ChoixPicCouleurPion((PictureBox)panel.Controls[i]);
                    frmPrmPerso.Jeu.JouerCoup(CoupAJouer, frmPrmPerso.Jeu.GetJoueurActif());
                    if (frmPrmPerso.Jeu.EstTerminee() == 1)
                        rejouer(true, frmPrmPerso.Joueur1.GetPseudoJoueur());
                    else if (frmPrmPerso.Jeu.EstTerminee() == 2)
                        rejouer(true, frmPrmPerso.Joueur2IA.GetPseudoJoueur());
                    else if (frmPrmPerso.Jeu.EstTerminee() == 0)
                        rejouer(false, "");
                    ChoixPicCouleurPion(picJActuel8x8);
                    break;

                }
                i++;
            }

        }
    }
}
