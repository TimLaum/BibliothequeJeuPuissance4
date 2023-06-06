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
    public partial class FormPartie8x8 : Form
    {
        private FormPartiePerso frmPrmPerso;
        public FormPartie8x8()
        {
            InitializeComponent();
        }
        private void FormPartie8x8_Load(object sender, EventArgs e)
        {
            frmPrmPerso = (FormPartiePerso)this.Owner;
            refreshPicJoueurActuel();
        }
        private void refreshPicJoueurActuel()
        {
            if (frmPrmPerso.Jeu.GetJoueurActif() == 1)
            {
                string x = frmPrmPerso.Joueur1.GetCouleur();
                if (x == "Rouge")
                {
                    picJActuel8x8.Image = Properties.Resources.Pion_Rouge;
                }
                if (x == "Jaune")
                {
                    picJActuel8x8.Image = Properties.Resources.Pion_Jaune;
                }
            }
            else
            {
                string x = frmPrmPerso.Joueur2IA.GetCouleur();
                if (x == "Noir")
                {
                    picJActuel8x8.Image = Properties.Resources.Pion_Noir;
                }
                if (x == "Jaune")
                {
                    picJActuel8x8.Image = Properties.Resources.Pion_Jaune;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
