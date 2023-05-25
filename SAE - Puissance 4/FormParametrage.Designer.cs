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
            panel1 = new Panel();
            btnQuitter = new Button();
            btnAPropos = new Button();
            btPartPerso = new Button();
            btn2J = new Button();
            btn1J = new Button();
            lblTitre = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnQuitter);
            panel1.Controls.Add(btnAPropos);
            panel1.Controls.Add(btPartPerso);
            panel1.Controls.Add(btn2J);
            panel1.Controls.Add(btn1J);
            panel1.Location = new Point(298, 91);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(559, 472);
            panel1.TabIndex = 3;
            // 
            // btnQuitter
            // 
            btnQuitter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnQuitter.Location = new Point(194, 377);
            btnQuitter.Margin = new Padding(3, 2, 3, 2);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(160, 41);
            btnQuitter.TabIndex = 4;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = true;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // btnAPropos
            // 
            btnAPropos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAPropos.Location = new Point(105, 270);
            btnAPropos.Margin = new Padding(3, 2, 3, 2);
            btnAPropos.Name = "btnAPropos";
            btnAPropos.Size = new Size(338, 40);
            btnAPropos.TabIndex = 3;
            btnAPropos.Text = "A Propos";
            btnAPropos.UseVisualStyleBackColor = true;
            btnAPropos.Click += btnAPropos_Click;
            // 
            // btPartPerso
            // 
            btPartPerso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btPartPerso.Location = new Point(105, 195);
            btPartPerso.Margin = new Padding(3, 2, 3, 2);
            btPartPerso.Name = "btPartPerso";
            btPartPerso.Size = new Size(338, 40);
            btPartPerso.TabIndex = 2;
            btPartPerso.Text = "Partie Personnalisée";
            btPartPerso.UseVisualStyleBackColor = true;
            // 
            // btn2J
            // 
            btn2J.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn2J.Location = new Point(105, 120);
            btn2J.Margin = new Padding(3, 2, 3, 2);
            btn2J.Name = "btn2J";
            btn2J.Size = new Size(338, 40);
            btn2J.TabIndex = 1;
            btn2J.Text = "2 Joueurs";
            btn2J.UseVisualStyleBackColor = true;
            // 
            // btn1J
            // 
            btn1J.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn1J.Location = new Point(105, 45);
            btn1J.Margin = new Padding(3, 2, 3, 2);
            btn1J.Name = "btn1J";
            btn1J.Size = new Size(338, 40);
            btn1J.TabIndex = 0;
            btn1J.Text = "1 Joueur";
            btn1J.UseVisualStyleBackColor = true;
            // 
            // lblTitre
            // 
            lblTitre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitre.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitre.Location = new Point(452, 11);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(227, 51);
            lblTitre.TabIndex = 2;
            lblTitre.Text = "Puissance 4";
            // 
            // FormParametrage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1152, 610);
            Controls.Add(panel1);
            Controls.Add(lblTitre);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormParametrage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnQuitter;
        private Button btnAPropos;
        private Button btPartPerso;
        private Button btn2J;
        private Button btn1J;
        private Label lblTitre;
    }
}