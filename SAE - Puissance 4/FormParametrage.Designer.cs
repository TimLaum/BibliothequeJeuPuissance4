namespace SAE___Puissance_4
{
    partial class FormParametrage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParametrage));
            panel1 = new Panel();
            btnQuitter = new Button();
            btnAPropos = new Button();
            btnPartPerso = new Button();
            btn2J = new Button();
            btn1J = new Button();
            lblTitre = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnQuitter);
            panel1.Controls.Add(btnAPropos);
            panel1.Controls.Add(btnPartPerso);
            panel1.Controls.Add(btn2J);
            panel1.Controls.Add(btn1J);
            panel1.Location = new Point(341, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(639, 629);
            panel1.TabIndex = 3;
            // 
            // btnQuitter
            // 
            btnQuitter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnQuitter.Location = new Point(222, 503);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(183, 55);
            btnQuitter.TabIndex = 4;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = true;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // btnAPropos
            // 
            btnAPropos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAPropos.Location = new Point(120, 360);
            btnAPropos.Name = "btnAPropos";
            btnAPropos.Size = new Size(386, 53);
            btnAPropos.TabIndex = 3;
            btnAPropos.Text = "A Propos";
            btnAPropos.UseVisualStyleBackColor = true;
            btnAPropos.Click += btnAPropos_Click;
            // 
            // btnPartPerso
            // 
            btnPartPerso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPartPerso.Location = new Point(120, 260);
            btnPartPerso.Name = "btnPartPerso";
            btnPartPerso.Size = new Size(386, 53);
            btnPartPerso.TabIndex = 2;
            btnPartPerso.Text = "Partie Personnalisée";
            btnPartPerso.UseVisualStyleBackColor = true;
            btnPartPerso.Click += btnPartPerso_Click;
            // 
            // btn2J
            // 
            btn2J.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn2J.Location = new Point(120, 160);
            btn2J.Name = "btn2J";
            btn2J.Size = new Size(386, 53);
            btn2J.TabIndex = 1;
            btn2J.Text = "2 Joueurs";
            btn2J.UseVisualStyleBackColor = true;
            btn2J.Click += btn2J_Click;
            // 
            // btn1J
            // 
            btn1J.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn1J.Location = new Point(120, 60);
            btn1J.Name = "btn1J";
            btn1J.Size = new Size(386, 53);
            btn1J.TabIndex = 0;
            btn1J.Text = "1 Joueur";
            btn1J.UseVisualStyleBackColor = true;
            btn1J.Click += btn1J_Click;
            // 
            // lblTitre
            // 
            lblTitre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitre.BackColor = Color.Transparent;
            lblTitre.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitre.ForeColor = SystemColors.Control;
            lblTitre.Location = new Point(517, 15);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(281, 68);
            lblTitre.TabIndex = 2;
            lblTitre.Text = "Puissance 4";
            // 
            // FormParametrage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1317, 813);
            Controls.Add(panel1);
            Controls.Add(lblTitre);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormParametrage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Accueil";
            FormClosing += FormParametrage_FormClosing;
            Load += FormParametrage_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnQuitter;
        private Button btnAPropos;
        private Button btnPartPerso;
        private Button btn2J;
        private Button btn1J;
        private Label lblTitre;
    }
}