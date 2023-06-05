namespace SAE___Puissance_4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picPlateau9x9 = new PictureBox();
            btnAbandon = new Button();
            lblTourJoueur = new Label();
            picJoueurActuel = new PictureBox();
            lblTitre9x9 = new Label();
            ((System.ComponentModel.ISupportInitialize)picPlateau9x9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picJoueurActuel).BeginInit();
            SuspendLayout();
            // 
            // picPlateau9x9
            // 
            picPlateau9x9.Location = new Point(208, 61);
            picPlateau9x9.Name = "picPlateau9x9";
            picPlateau9x9.Size = new Size(932, 646);
            picPlateau9x9.TabIndex = 66;
            picPlateau9x9.TabStop = false;
            // 
            // btnAbandon
            // 
            btnAbandon.Location = new Point(692, 713);
            btnAbandon.Name = "btnAbandon";
            btnAbandon.Size = new Size(319, 51);
            btnAbandon.TabIndex = 65;
            btnAbandon.Text = "Abandonner la partie";
            btnAbandon.UseVisualStyleBackColor = true;
            // 
            // lblTourJoueur
            // 
            lblTourJoueur.AutoSize = true;
            lblTourJoueur.Location = new Point(371, 766);
            lblTourJoueur.Name = "lblTourJoueur";
            lblTourJoueur.Size = new Size(130, 20);
            lblTourJoueur.TabIndex = 64;
            lblTourJoueur.Text = "Au tour du Joueur ";
            // 
            // picJoueurActuel
            // 
            picJoueurActuel.BackgroundImageLayout = ImageLayout.Zoom;
            picJoueurActuel.Location = new Point(404, 712);
            picJoueurActuel.Name = "picJoueurActuel";
            picJoueurActuel.Size = new Size(46, 52);
            picJoueurActuel.SizeMode = PictureBoxSizeMode.Zoom;
            picJoueurActuel.TabIndex = 63;
            picJoueurActuel.TabStop = false;
            // 
            // lblTitre9x9
            // 
            lblTitre9x9.AutoSize = true;
            lblTitre9x9.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitre9x9.Location = new Point(524, -5);
            lblTitre9x9.Name = "lblTitre9x9";
            lblTitre9x9.Size = new Size(280, 62);
            lblTitre9x9.TabIndex = 62;
            lblTitre9x9.Text = "Puissance 4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 793);
            Controls.Add(picPlateau9x9);
            Controls.Add(btnAbandon);
            Controls.Add(lblTourJoueur);
            Controls.Add(picJoueurActuel);
            Controls.Add(lblTitre9x9);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picPlateau9x9).EndInit();
            ((System.ComponentModel.ISupportInitialize)picJoueurActuel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picPlateau9x9;
        private Button btnAbandon;
        private Label lblTourJoueur;
        private PictureBox picJoueurActuel;
        private Label lblTitre9x9;
    }
}