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
            panel1.Controls.Add(btnQuitter);
            panel1.Controls.Add(btnAPropos);
            panel1.Controls.Add(btPartPerso);
            panel1.Controls.Add(btn2J);
            panel1.Controls.Add(btn1J);
            panel1.Location = new Point(340, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(639, 629);
            panel1.TabIndex = 3;
            // 
            // btnQuitter
            // 
            btnQuitter.Location = new Point(222, 503);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(183, 55);
            btnQuitter.TabIndex = 4;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = true;
            // 
            // btnAPropos
            // 
            btnAPropos.Location = new Point(120, 360);
            btnAPropos.Name = "btnAPropos";
            btnAPropos.Size = new Size(386, 54);
            btnAPropos.TabIndex = 3;
            btnAPropos.Text = "A Propos";
            btnAPropos.UseVisualStyleBackColor = true;
            // 
            // btPartPerso
            // 
            btPartPerso.Location = new Point(120, 260);
            btPartPerso.Name = "btPartPerso";
            btPartPerso.Size = new Size(386, 54);
            btPartPerso.TabIndex = 2;
            btPartPerso.Text = "Partie Personnalisée";
            btPartPerso.UseVisualStyleBackColor = true;
            // 
            // btn2J
            // 
            btn2J.Location = new Point(120, 160);
            btn2J.Name = "btn2J";
            btn2J.Size = new Size(386, 54);
            btn2J.TabIndex = 1;
            btn2J.Text = "2 Joueurs";
            btn2J.UseVisualStyleBackColor = true;
            // 
            // btn1J
            // 
            btn1J.Location = new Point(120, 60);
            btn1J.Name = "btn1J";
            btn1J.Size = new Size(386, 54);
            btn1J.TabIndex = 0;
            btn1J.Text = "1 Joueur";
            btn1J.UseVisualStyleBackColor = true;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitre.Location = new Point(516, 15);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(280, 62);
            lblTitre.TabIndex = 2;
            lblTitre.Text = "Puissance 4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1316, 813);
            Controls.Add(panel1);
            Controls.Add(lblTitre);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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