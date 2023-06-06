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
            btnAbandon8x8 = new Button();
            lblTourJoueur8x8 = new Label();
            picJActuel8x8 = new PictureBox();
            pnlPlateau8x8 = new Panel();
            ((System.ComponentModel.ISupportInitialize)picJActuel8x8).BeginInit();
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
            // btnAbandon8x8
            // 
            btnAbandon8x8.Location = new Point(628, 859);
            btnAbandon8x8.Name = "btnAbandon8x8";
            btnAbandon8x8.Size = new Size(319, 51);
            btnAbandon8x8.TabIndex = 6;
            btnAbandon8x8.Text = "Abandonner la partie";
            btnAbandon8x8.UseVisualStyleBackColor = true;
            // 
            // lblTourJoueur8x8
            // 
            lblTourJoueur8x8.AutoSize = true;
            lblTourJoueur8x8.Location = new Point(307, 912);
            lblTourJoueur8x8.Name = "lblTourJoueur8x8";
            lblTourJoueur8x8.Size = new Size(130, 20);
            lblTourJoueur8x8.TabIndex = 5;
            lblTourJoueur8x8.Text = "Au tour du Joueur ";
            // 
            // picJActuel8x8
            // 
            picJActuel8x8.BackgroundImageLayout = ImageLayout.Zoom;
            picJActuel8x8.Location = new Point(340, 858);
            picJActuel8x8.Name = "picJActuel8x8";
            picJActuel8x8.Size = new Size(46, 52);
            picJActuel8x8.SizeMode = PictureBoxSizeMode.Zoom;
            picJActuel8x8.TabIndex = 4;
            picJActuel8x8.TabStop = false;
            // 
            // pnlPlateau8x8
            // 
            pnlPlateau8x8.BackgroundImage = Properties.Resources.Plateau_8_8v5;
            pnlPlateau8x8.Location = new Point(174, 97);
            pnlPlateau8x8.Name = "pnlPlateau8x8";
            pnlPlateau8x8.Size = new Size(848, 718);
            pnlPlateau8x8.TabIndex = 7;
            // 
            // FormPartie8x8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1444, 962);
            Controls.Add(pnlPlateau8x8);
            Controls.Add(btnAbandon8x8);
            Controls.Add(lblTourJoueur8x8);
            Controls.Add(picJActuel8x8);
            Controls.Add(lblTitre6x7);
            Name = "FormPartie8x8";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picJActuel8x8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitre6x7;
        private Button btnAbandon8x8;
        private Label lblTourJoueur8x8;
        private PictureBox picJActuel8x8;
        private Panel pnlPlateau8x8;
    }
}