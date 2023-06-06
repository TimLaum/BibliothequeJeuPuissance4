namespace SAE___Puissance_4
{
    partial class FormPartie9x9
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
            pnlPlateau9x9 = new Panel();
            btnAbandon9x9 = new Button();
            lblTourJoueur9x9 = new Label();
            picJActuel9x9 = new PictureBox();
            lblTitre9x9 = new Label();
            ((System.ComponentModel.ISupportInitialize)picJActuel9x9).BeginInit();
            SuspendLayout();
            // 
            // pnlPlateau9x9
            // 
            pnlPlateau9x9.Location = new Point(227, 96);
            pnlPlateau9x9.Name = "pnlPlateau9x9";
            pnlPlateau9x9.Size = new Size(826, 629);
            pnlPlateau9x9.TabIndex = 12;
            // 
            // btnAbandon9x9
            // 
            btnAbandon9x9.Location = new Point(608, 732);
            btnAbandon9x9.Name = "btnAbandon9x9";
            btnAbandon9x9.Size = new Size(319, 51);
            btnAbandon9x9.TabIndex = 11;
            btnAbandon9x9.Text = "Abandonner la partie";
            btnAbandon9x9.UseVisualStyleBackColor = true;
            // 
            // lblTourJoueur9x9
            // 
            lblTourJoueur9x9.AutoSize = true;
            lblTourJoueur9x9.Location = new Point(287, 785);
            lblTourJoueur9x9.Name = "lblTourJoueur9x9";
            lblTourJoueur9x9.Size = new Size(130, 20);
            lblTourJoueur9x9.TabIndex = 10;
            lblTourJoueur9x9.Text = "Au tour du Joueur ";
            // 
            // picJActuel9x9
            // 
            picJActuel9x9.BackgroundImageLayout = ImageLayout.Zoom;
            picJActuel9x9.Location = new Point(320, 731);
            picJActuel9x9.Name = "picJActuel9x9";
            picJActuel9x9.Size = new Size(46, 52);
            picJActuel9x9.SizeMode = PictureBoxSizeMode.Zoom;
            picJActuel9x9.TabIndex = 9;
            picJActuel9x9.TabStop = false;
            // 
            // lblTitre9x9
            // 
            lblTitre9x9.AutoSize = true;
            lblTitre9x9.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitre9x9.Location = new Point(463, 2);
            lblTitre9x9.Name = "lblTitre9x9";
            lblTitre9x9.Size = new Size(280, 62);
            lblTitre9x9.TabIndex = 8;
            lblTitre9x9.Text = "Puissance 4";
            // 
            // FormPartie9x9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 806);
            Controls.Add(pnlPlateau9x9);
            Controls.Add(btnAbandon9x9);
            Controls.Add(lblTourJoueur9x9);
            Controls.Add(picJActuel9x9);
            Controls.Add(lblTitre9x9);
            Name = "FormPartie9x9";
            ((System.ComponentModel.ISupportInitialize)picJActuel9x9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlPlateau9x9;
        private Button btnAbandon9x9;
        private Label lblTourJoueur9x9;
        private PictureBox picJActuel9x9;
        private Label lblTitre9x9;
    }
}