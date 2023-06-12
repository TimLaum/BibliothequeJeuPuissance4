namespace SAE___Puissance_4
{
    partial class FormAPropos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAPropos));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnRetour = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(242, 31);
            label1.Name = "label1";
            label1.Size = new Size(280, 62);
            label1.TabIndex = 0;
            label1.Text = "Puissance 4";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(279, 113);
            label2.Name = "label2";
            label2.Size = new Size(172, 46);
            label2.TabIndex = 1;
            label2.Text = "A Propos :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(171, 187);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Version :";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(171, 272);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 3;
            label4.Text = "Développé par :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(342, 187);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 4;
            label5.Text = "1 . 0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(342, 272);
            label6.Name = "label6";
            label6.Size = new Size(173, 100);
            label6.TabIndex = 5;
            label6.Text = "Antoine PISSON\r\nAntoine COUTREEL\r\nMalcolm WALTER\r\nClaire VIGUOINE\r\nTimothée L'AUMONNIER";
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(271, 448);
            btnRetour.Margin = new Padding(3, 2, 3, 2);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(199, 34);
            btnRetour.TabIndex = 6;
            btnRetour.Text = "RETOUR";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // FormAPropos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(738, 520);
            Controls.Add(btnRetour);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormAPropos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "A Propos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnRetour;
    }
}