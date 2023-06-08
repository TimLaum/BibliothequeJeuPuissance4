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
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE___Puissance_4
{
    public partial class FormPartie6x7 : Form
    {
        private FormPartiePerso? frmPrmPerso;
        public FormPartie6x7()
        {
            InitializeComponent();
        }

        private void FormPartie6x7_Load(object sender, EventArgs e)
        {
            frmPrmPerso = (FormPartiePerso)this.Owner;
            ChoixPicCouleurPion(picJoueurActuel);


        }
        private void ChoixPicCouleurPion(PictureBox pic)
        {
            if (frmPrmPerso.Jeu.GetJoueurActif() == 1)
            {
                string x = frmPrmPerso.Joueur1.GetCouleur();
                if (x == "Rouge")
                {
                    pic.Image = Properties.Resources.Pion_Rouge;
                }
                if (x == "Jaune")
                {
                    pic.Image = Properties.Resources.Pion_Jaune;
                }
            }
            else
            {
                string x = frmPrmPerso.Joueur2IA.GetCouleur();
                if (x == "Noir")
                {
                    pic.Image = Properties.Resources.Pion_Noir;
                }
                if (x == "Jaune")
                {
                    pic.Image = Properties.Resources.Pion_Jaune;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picC1_click(object sender, EventArgs e)
        {
            int i = frmPrmPerso.Jeu.GetLignes() - 1;
            int nbpanels = pnlPlateau6x7.Controls.Count;
            PictureBox pic = new PictureBox();
            while (i >= 0)
            {
                if (frmPrmPerso.Jeu.GetPion(i, 1) == 0)
                {
                    ChoixPicCouleurPion((PictureBox)pnlPlateau6x7.Controls[nbpanels % 6 * 7]);
                }
                i--;
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            List<(int, int)> CoupAJouer = new List<(int, int)>();
            int i = 0;
            while (i < frmPrmPerso.Jeu.GetLignes())
            {
                if (frmPrmPerso.Jeu.GetPion(i, 1) == 0)
                {
                    CoupAJouer.Add((i, 1));
                    ChoixPicCouleurPion((PictureBox)panel1.Controls[i]);
                    frmPrmPerso.Jeu.JouerCoup(CoupAJouer, frmPrmPerso.Jeu.GetJoueurActif());
                    i = frmPrmPerso.Jeu.GetLignes();

                }
                i++;
            }

        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {

        }
    }
}
