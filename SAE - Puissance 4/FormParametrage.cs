namespace SAE___Puissance_4
{
    public partial class FormParametrage : Form
    {
        public FormParametrage()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAPropos_Click(object sender, EventArgs e)
        {
            FormAPropos APropos = new FormAPropos();
            APropos.ShowDialog();
        }
    }
}