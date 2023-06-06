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
            if (frmPrmPerso.Jeu.GetJoueurActif() == 1)
            {
                string x = frmPrmPerso.Joueur1.GetCouleur();
                if (x == "Rouge")
                {
                    picJActuel9x9.Image = Properties.Resources.Pion_Rouge;
                }
                if (x == "Jaune")
                {
                    picJActuel9x9.Image = Properties.Resources.Pion_Jaune;
                }
            }
            else
            {
                string x = frmPrmPerso.Joueur2IA.GetCouleur();
                if (x == "Noir")
                {
                    picJActuel9x9.Image = Properties.Resources.Pion_Noir;
                }
                if (x == "Jaune")
                {
                    picJActuel9x9.Image = Properties.Resources.Pion_Jaune;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
