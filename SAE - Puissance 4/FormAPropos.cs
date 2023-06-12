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
    public partial class FormAPropos : Form
    {
        public FormAPropos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fonction qui ferme le Form lorsque le bouton est cliqué
        /// </summary>
        /// <returns></returns>
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
