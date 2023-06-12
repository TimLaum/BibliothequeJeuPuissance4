namespace SAE___Puissance_4
{
    public partial class FormParametrage : Form
    {
        /// <summary>
        /// Variable qui détermine si le but est de quitter le formulaire ou fermer l'application
        /// </summary>
        bool exit;

        /// <summary>
        /// Variable qui détermine si le prochain form aura deux joueurs ou un joueur et une IA
        /// </summary>
        public bool type_form;
        public FormParametrage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fonction qui ferme l'application lorsque le bouton quitter est pressé
        /// </summary>
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Fonction qui affiche le FormAPropos
        /// </summary>
        private void btnAPropos_Click(object sender, EventArgs e)
        {
            FormAPropos APropos = new FormAPropos();
            this.Hide();
            APropos.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Fonction qui instancie les variables au chargement du Form
        /// </summary>
        private void FormParametrage_Load(object sender, EventArgs e)
        {
            exit = true;
        }

        /// <summary>
        /// Fonction qui ferme l'application lorsque le Form est fermé
        /// </summary>
        private void FormParametrage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit == true)
                Environment.Exit(0);
        }

        /// <summary>
        /// Fonction qui affiche le prochain FormPartiePerso avec des réglages définis sur Joueur vs IA lorsque cliqué
        /// </summary>
        private void btn1J_Click(object sender, EventArgs e)
        {
            exit = false;
            type_form = true;
            Form PartiePerso = new FormPartiePerso();
            this.Hide();
            PartiePerso.ShowDialog(this);
            this.Show();
        }

        /// <summary>
        /// Fonction qui affiche le prochain FormPartiePerso lorsque cliqué
        /// </summary>
        private void btnPartPerso_Click(object sender, EventArgs e)
        {
            exit = false;
            type_form = false;
            Form PartiePerso = new FormPartiePerso();
            this.Hide();
            PartiePerso.ShowDialog(this);
            this.Show();
        }

        /// <summary>
        /// Fonction qui affiche le prochain FormPartiePerso avec des réglages définis sur Joueur vs Joueur lorsque cliqué
        /// </summary>
        private void btn2J_Click(object sender, EventArgs e)
        {
            exit = false;
            type_form = false;
            Form PartiePerso = new FormPartiePerso();
            this.Hide();
            PartiePerso.ShowDialog(this);
            this.Show();
        }
    }
}