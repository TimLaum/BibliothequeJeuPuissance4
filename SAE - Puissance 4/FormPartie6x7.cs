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
        private FormPartiePerso frmPrmPerso;
        public FormPartie6x7()
        {
            InitializeComponent();
        }

        private void FormPartie6x7_Load(object sender, EventArgs e)
        {
            frmPrmPerso = (FormPartiePerso)this.Owner;
            if (frmPrmPerso.Jeu.GetJoueurActif() == 1)
            {
                string x = frmPrmPerso.Joueur1.GetCouleur();
                if (x == "Rouge")
                {
                    picJoueurActuel.Image = Properties.Resources.Pion_Rouge;
                }
                if (x == "Jaune")
                {
                    picJoueurActuel.Image = Properties.Resources.Pion_Jaune;
                }
            }
            else
            {
                string x = frmPrmPerso.Joueur2IA.GetCouleur();
                if (x == "Noir")
                {
                    picJoueurActuel.Image = Properties.Resources.Pion_Noir;
                }
                if (x == "Jaune")
                {
                    picJoueurActuel.Image = Properties.Resources.Pion_Jaune;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }     
    }
}
