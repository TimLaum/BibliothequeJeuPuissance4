namespace SAE___Puissance_4
{
    partial class FormPartiePerso
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
            button1 = new Button();
            rbnRandom = new RadioButton();
            rbnJ2IA = new RadioButton();
            rbnJ1 = new RadioButton();
            label5 = new Label();
            lblPseudos = new Label();
            pnlPseudos = new Panel();
            txbJ2 = new TextBox();
            txbJ1 = new TextBox();
            lblJ2 = new Label();
            lblJ1 = new Label();
            panel3 = new Panel();
            rbnRN = new RadioButton();
            rbnBN = new RadioButton();
            rbnRJ = new RadioButton();
            panel2 = new Panel();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            panel1 = new Panel();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            pnlPseudos.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(264, 418);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(235, 43);
            button1.TabIndex = 26;
            button1.Text = "JOUER !";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rbnRandom
            // 
            rbnRandom.AutoSize = true;
            rbnRandom.Location = new Point(565, 368);
            rbnRandom.Margin = new Padding(3, 2, 3, 2);
            rbnRandom.Name = "rbnRandom";
            rbnRandom.Size = new Size(72, 19);
            rbnRandom.TabIndex = 25;
            rbnRandom.Text = "Aléatoire";
            rbnRandom.UseVisualStyleBackColor = true;
            // 
            // rbnJ2IA
            // 
            rbnJ2IA.AutoSize = true;
            rbnJ2IA.Location = new Point(334, 368);
            rbnJ2IA.Margin = new Padding(3, 2, 3, 2);
            rbnJ2IA.Name = "rbnJ2IA";
            rbnJ2IA.Size = new Size(100, 19);
            rbnJ2IA.TabIndex = 24;
            rbnJ2IA.Text = "Joueur 2 ou IA";
            rbnJ2IA.UseVisualStyleBackColor = true;
            // 
            // rbnJ1
            // 
            rbnJ1.AutoSize = true;
            rbnJ1.Checked = true;
            rbnJ1.Location = new Point(142, 368);
            rbnJ1.Margin = new Padding(3, 2, 3, 2);
            rbnJ1.Name = "rbnJ1";
            rbnJ1.Size = new Size(69, 19);
            rbnJ1.TabIndex = 23;
            rbnJ1.TabStop = true;
            rbnJ1.Text = "Joueur 1";
            rbnJ1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(290, 336);
            label5.Name = "label5";
            label5.Size = new Size(187, 15);
            label5.TabIndex = 22;
            label5.Text = "Choix du joueur débutant la partie";
            // 
            // lblPseudos
            // 
            lblPseudos.AutoSize = true;
            lblPseudos.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblPseudos.Location = new Point(108, 199);
            lblPseudos.Name = "lblPseudos";
            lblPseudos.Size = new Size(99, 30);
            lblPseudos.TabIndex = 21;
            lblPseudos.Text = "Pseudos";
            // 
            // pnlPseudos
            // 
            pnlPseudos.Controls.Add(txbJ2);
            pnlPseudos.Controls.Add(txbJ1);
            pnlPseudos.Controls.Add(lblJ2);
            pnlPseudos.Controls.Add(lblJ1);
            pnlPseudos.Location = new Point(88, 217);
            pnlPseudos.Margin = new Padding(3, 2, 3, 2);
            pnlPseudos.Name = "pnlPseudos";
            pnlPseudos.Size = new Size(603, 105);
            pnlPseudos.TabIndex = 20;
            // 
            // txbJ2
            // 
            txbJ2.Location = new Point(245, 61);
            txbJ2.Margin = new Padding(3, 2, 3, 2);
            txbJ2.MaxLength = 30;
            txbJ2.Name = "txbJ2";
            txbJ2.Size = new Size(285, 23);
            txbJ2.TabIndex = 3;
            // 
            // txbJ1
            // 
            txbJ1.Location = new Point(245, 19);
            txbJ1.Margin = new Padding(3, 2, 3, 2);
            txbJ1.MaxLength = 30;
            txbJ1.Name = "txbJ1";
            txbJ1.Size = new Size(285, 23);
            txbJ1.TabIndex = 2;
            // 
            // lblJ2
            // 
            lblJ2.AutoSize = true;
            lblJ2.Location = new Point(65, 66);
            lblJ2.Name = "lblJ2";
            lblJ2.Size = new Size(51, 15);
            lblJ2.TabIndex = 1;
            lblJ2.Text = "Joueur 2";
            // 
            // lblJ1
            // 
            lblJ1.AutoSize = true;
            lblJ1.Location = new Point(65, 24);
            lblJ1.Name = "lblJ1";
            lblJ1.Size = new Size(51, 15);
            lblJ1.TabIndex = 0;
            lblJ1.Text = "Joueur 1";
            // 
            // panel3
            // 
            panel3.Controls.Add(rbnRN);
            panel3.Controls.Add(rbnBN);
            panel3.Controls.Add(rbnRJ);
            panel3.Location = new Point(290, 121);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(386, 32);
            panel3.TabIndex = 18;
            // 
            // rbnRN
            // 
            rbnRN.AutoSize = true;
            rbnRN.Location = new Point(267, 8);
            rbnRN.Margin = new Padding(3, 2, 3, 2);
            rbnRN.Name = "rbnRN";
            rbnRN.Size = new Size(93, 19);
            rbnRN.TabIndex = 2;
            rbnRN.Text = "Rouge / Noir";
            rbnRN.UseVisualStyleBackColor = true;
            rbnRN.CheckedChanged += rbnRN_CheckedChanged;
            // 
            // rbnBN
            // 
            rbnBN.AutoSize = true;
            rbnBN.Location = new Point(130, 8);
            rbnBN.Margin = new Padding(3, 2, 3, 2);
            rbnBN.Name = "rbnBN";
            rbnBN.Size = new Size(88, 19);
            rbnBN.TabIndex = 1;
            rbnBN.Text = "Blanc / Noir";
            rbnBN.UseVisualStyleBackColor = true;
            rbnBN.CheckedChanged += rbnBN_CheckedChanged;
            // 
            // rbnRJ
            // 
            rbnRJ.AutoSize = true;
            rbnRJ.Checked = true;
            rbnRJ.Location = new Point(3, 8);
            rbnRJ.Margin = new Padding(3, 2, 3, 2);
            rbnRJ.Name = "rbnRJ";
            rbnRJ.Size = new Size(100, 19);
            rbnRJ.TabIndex = 0;
            rbnRJ.TabStop = true;
            rbnRJ.Text = "Rouge / Jaune";
            rbnRJ.UseVisualStyleBackColor = true;
            rbnRJ.CheckedChanged += rbnRJ_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(radioButton8);
            panel2.Controls.Add(radioButton7);
            panel2.Location = new Point(290, 157);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(386, 32);
            panel2.TabIndex = 19;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Checked = true;
            radioButton8.Location = new Point(3, 8);
            radioButton8.Margin = new Padding(3, 2, 3, 2);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(60, 19);
            radioButton8.TabIndex = 1;
            radioButton8.TabStop = true;
            radioButton8.Text = "Joueur";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(130, 8);
            radioButton7.Margin = new Padding(3, 2, 3, 2);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(36, 19);
            radioButton7.TabIndex = 0;
            radioButton7.Text = "IA";
            radioButton7.UseVisualStyleBackColor = true;
            radioButton7.CheckedChanged += radioButton7_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(290, 85);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 32);
            panel1.TabIndex = 17;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(267, 8);
            radioButton3.Margin = new Padding(3, 2, 3, 2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(49, 19);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "9 x 9";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(130, 8);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(49, 19);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "8 x 8";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(3, 8);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(49, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "6 x 7";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 167);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 16;
            label4.Text = "Choix de l'adversaire";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 131);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 15;
            label3.Text = "Couleur des pions";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(88, 94);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 14;
            label2.Text = "Taille du plateau";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(164, 7);
            label1.Name = "label1";
            label1.Size = new Size(382, 51);
            label1.TabIndex = 13;
            label1.Text = "Partie Personnalisée";
            // 
            // panel4
            // 
            panel4.Location = new Point(88, 354);
            panel4.Name = "panel4";
            panel4.Size = new Size(603, 44);
            panel4.TabIndex = 27;
            // 
            // FormPartiePerso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(752, 484);
            Controls.Add(button1);
            Controls.Add(rbnRandom);
            Controls.Add(rbnJ2IA);
            Controls.Add(rbnJ1);
            Controls.Add(label5);
            Controls.Add(lblPseudos);
            Controls.Add(pnlPseudos);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel4);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormPartiePerso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Partie personnalisée";
            FormClosed += FormPartiePerso_FormClosed;
            Load += FormPartiePerso_Load;
            pnlPseudos.ResumeLayout(false);
            pnlPseudos.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RadioButton rbnRandom;
        private RadioButton rbnJ2IA;
        private RadioButton rbnJ1;
        private Label label5;
        private Label lblPseudos;
        private Panel pnlPseudos;
        private TextBox txbJ2;
        private TextBox txbJ1;
        private Label lblJ2;
        private Label lblJ1;
        private Panel panel3;
        private RadioButton rbnRN;
        private RadioButton rbnBN;
        private RadioButton rbnRJ;
        private Panel panel2;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private Panel panel1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel4;
    }
}