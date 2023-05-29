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
        public FormPartie6x7()
        {
            InitializeComponent();
        }

        private void FormPartie6x7_Load(object sender, EventArgs e)
        {
            pictureBox44.Visible = true;
            pictureBox44.Image = Properties.Resources.Pion_Noir;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
