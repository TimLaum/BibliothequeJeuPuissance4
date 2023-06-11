using BibliothequeJeuPuissance4;
using Microsoft.VisualBasic.ApplicationServices;
using SAE___Puissance_4.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE___Puissance_4
{
    public partial class FormPartie6x7 : Form
    {
        private FormPartiePerso? frmPrmPerso;
        int columnNumber;
        private SoundPlayer Musique = new SoundPlayer(Properties.Resources.Musique);
        public FormPartie6x7()
        {
            InitializeComponent();
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
        private void FormPartie6x7_Load(object sender, EventArgs e)
        {
            frmPrmPerso = (FormPartiePerso)this.Owner;
            playLooping();
            ChoixPicCouleurPion(picJoueurActuel);
            Panel_Transparence(pnlC1);
            Panel_Transparence(pnlC2);
            Panel_Transparence(pnlC3);
            Panel_Transparence(pnlC4);
            Panel_Transparence(pnlC5);
            Panel_Transparence(pnlC6);
            Panel_Transparence(pnlC7);
            lblTourJoueur.Text = $"Au tour du joueur {frmPrmPerso.Jeu.GetJoueurActif()}";
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
                Musique.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error playing sound");
            }
        }

        private void ChoixPicCouleurPion(PictureBox pic)
        {
            VoirPlateau();
            if (frmPrmPerso.Jeu.GetJoueurActif() == 1)
            {
                string x = frmPrmPerso.Joueur1.GetCouleur();
                if (x == "Rouge")
                {
                    pic.Image = Properties.Resources.PionRougeP6x7;
                }
                if (x == "Jaune")
                {
                    pic.Image = Properties.Resources.PionJauneP6x7;
                }
            }
            else
            {
                string x = frmPrmPerso.Joueur2IA.GetCouleur();
                if (x == "Noir")
                {
                    pic.Image = Properties.Resources.PionNoirP6x7;
                }
                if (x == "Jaune")
                {
                    pic.Image = Properties.Resources.PionJauneP6x7;
                }
            }
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
            IA JoueurIA = new IA(4, 2);
            
            int i = 0;
            List<(int, int)> CoupAJouer = new List<(int, int)>();
            CoupAJouer = JoueurIA.MeilleurCoup(frmPrmPerso.Jeu);
            string nomPanel = string.Format("pnlC{0}", CoupAJouer[0].Item2+1);
            Panel panel = Controls.Find(nomPanel,true).FirstOrDefault() as Panel;
            ChoixPicCouleurPion((PictureBox)panel.Controls[frmPrmPerso.Jeu.GetLignes()-(CoupAJouer[0].Item1) - 1]);
            frmPrmPerso.Jeu.JouerCoup(CoupAJouer, frmPrmPerso.Jeu.GetJoueurActif());
            ChoixPicCouleurPion(picJoueurActuel);
            VoirPlateau();


        }
        private void VoirPlateau()
        {
            List<int> x = new List<int>();
            for(int i=0;i< frmPrmPerso.Jeu.GetLignes(); i++)
            {
                for (int j = 0; j < frmPrmPerso.Jeu.GetColonnes(); j++)
                {
                    x.Add(frmPrmPerso.Jeu.GetPion(i,j ));
                }

            }
            MessageBox.Show($"{frmPrmPerso.Jeu.GetPion(5,0)}");
            DialogResult rejouer = MessageBox.Show($"{x[0]},{x[1]},{x[2]},{x[3]},{x[4]},{x[5]},{x[6]};\n{x[7]},{x[8]},{x[9]},{x[10]},{x[11]},{x[12]},{x[13]};\n{x[14]},{x[15]},{x[16]},{x[17]},{x[18]},{x[19]},{x[20]};\n {x[21]},{x[22]},{x[23]},{x[24]},{x[25]},{x[26]},{x[27]};\n{x[28]},{x[29]},{x[30]},{x[31]},{x[32]},{x[33]},{x[34]}\n{x[35]},{x[36]},{x[37]},{x[38]},{x[39]},{x[40]},{x[41]}");

        }
        private void pnlC_Click(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            List<(int, int)> CoupAJouer = new List<(int, int)>();
            int i = frmPrmPerso.Jeu.GetLignes()-1;
            while (i >= 0)
            {
                if (frmPrmPerso.Jeu.EstPossible(i, columnNumber))
                {
                    CoupAJouer.Add((i, columnNumber));
                    ChoixPicCouleurPion((PictureBox)panel.Controls[frmPrmPerso.Jeu.GetLignes()-1-i]);
                    frmPrmPerso.Jeu.JouerCoup(CoupAJouer, frmPrmPerso.Jeu.GetJoueurActif());
                    if (frmPrmPerso.Jeu.EstTerminee() == 1)
                        rejouer(true, frmPrmPerso.Joueur1.GetPseudoJoueur());
                    else if (frmPrmPerso.Jeu.EstTerminee() == 2)
                        rejouer(true, frmPrmPerso.Joueur2IA.GetPseudoJoueur());
                    else if (frmPrmPerso.Jeu.EstTerminee() == 0)
                        rejouer(false, "");
                    ChoixPicCouleurPion(picJoueurActuel);
                    if (frmPrmPerso.Joueur2IA.GetPseudoJoueur() == "IA" && frmPrmPerso.Jeu.GetJoueurActif() == frmPrmPerso.Joueur2IA.GetN_Joueur())
                    {
                        appelleIA();
                    }
                    break;
                    
                }
                i--;
                
            }

        }

        private void FormPartie6x7_FormClosed(object sender, FormClosedEventArgs e)
        {
            Musique.Stop();
        }

        private void btnAbandon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
