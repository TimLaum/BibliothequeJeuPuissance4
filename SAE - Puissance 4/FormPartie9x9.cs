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
    public partial class FormPartie9x9 : Form
    {
        private FormPartiePerso frmPrmPerso;
        public FormPartie9x9()
        {
            InitializeComponent();
        }
        private void FormPartie9x9_Load(object sender, EventArgs e)
        {
            frmPrmPerso = (FormPartiePerso)this.Owner;
            ChoixPicCouleurPion(picJActuel9x9);

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

        private void pictureBox63_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox62_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox61_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox60_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox58_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox57_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox55_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox64_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox65_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox66_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox67_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox68_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox69_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox70_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox71_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox72_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox81_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox80_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox79_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox78_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox77_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox76_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox75_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox74_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox73_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }
    }
}
