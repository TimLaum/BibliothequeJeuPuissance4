namespace SAE___Puissance_4
{
    partial class FormPartie8x8
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
            lblTitre6x7 = new Label();
            btnAbandon = new Button();
            lblTourJoueur = new Label();
            picJoueurActuel = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)picJoueurActuel).BeginInit();
            SuspendLayout();
            // 
            // lblTitre6x7
            // 
            lblTitre6x7.AutoSize = true;
            lblTitre6x7.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitre6x7.Location = new Point(472, 18);
            lblTitre6x7.Name = "lblTitre6x7";
            lblTitre6x7.Size = new Size(280, 62);
            lblTitre6x7.TabIndex = 1;
            lblTitre6x7.Text = "Puissance 4";
            // 
            // btnAbandon
            // 
            btnAbandon.Location = new Point(617, 748);
            btnAbandon.Name = "btnAbandon";
            btnAbandon.Size = new Size(319, 51);
            btnAbandon.TabIndex = 6;
            btnAbandon.Text = "Abandonner la partie";
            btnAbandon.UseVisualStyleBackColor = true;
            // 
            // lblTourJoueur
            // 
            lblTourJoueur.AutoSize = true;
            lblTourJoueur.Location = new Point(296, 801);
            lblTourJoueur.Name = "lblTourJoueur";
            lblTourJoueur.Size = new Size(130, 20);
            lblTourJoueur.TabIndex = 5;
            lblTourJoueur.Text = "Au tour du Joueur ";
            // 
            // picJoueurActuel
            // 
            picJoueurActuel.BackgroundImageLayout = ImageLayout.Zoom;
            picJoueurActuel.Location = new Point(329, 747);
            picJoueurActuel.Name = "picJoueurActuel";
            picJoueurActuel.Size = new Size(46, 52);
            picJoueurActuel.SizeMode = PictureBoxSizeMode.Zoom;
            picJoueurActuel.TabIndex = 4;
            picJoueurActuel.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(236, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(826, 629);
            panel1.TabIndex = 7;
            // 
            // FormPartie8x8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 841);
            Controls.Add(panel1);
            Controls.Add(btnAbandon);
            Controls.Add(lblTourJoueur);
            Controls.Add(picJoueurActuel);
            Controls.Add(lblTitre6x7);
            Name = "FormPartie8x8";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picJoueurActuel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitre6x7;
        private Button btnAbandon;
        private Label lblTourJoueur;
        private PictureBox picJoueurActuel;
        private Panel panel1;
    }
}