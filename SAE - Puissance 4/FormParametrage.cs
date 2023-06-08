namespace SAE___Puissance_4
{
    public partial class FormParametrage : Form
    {
        bool exit;
        public bool type_form;
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
            this.Hide();
            APropos.ShowDialog();
            this.Show();
        }

        private void FormParametrage_Load(object sender, EventArgs e)
        {
            exit = true;
        }

        private void FormParametrage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit == true)
                Environment.Exit(0);
        }

        private void btn1J_Click(object sender, EventArgs e)
        {
            exit = false;
            type_form = true;
            Form PartiePerso = new FormPartiePerso();
            this.Hide();
            PartiePerso.ShowDialog(this);
        }

        private void btnPartPerso_Click(object sender, EventArgs e)
        {
            exit = false;
            type_form = false;
            Form PartiePerso = new FormPartiePerso();
            this.Hide();
            PartiePerso.ShowDialog(this);
            
        }

        private void btn2J_Click(object sender, EventArgs e)
        {
            exit = false;
            type_form = false;
            Form PartiePerso = new FormPartiePerso();
            this.Hide();
            PartiePerso.ShowDialog(this);
        }
    }
}