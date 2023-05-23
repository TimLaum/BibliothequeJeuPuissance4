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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(277, 41);
            label1.Name = "label1";
            label1.Size = new Size(280, 62);
            label1.TabIndex = 0;
            label1.Text = "Puissance 4";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(319, 151);
            label2.Name = "label2";
            label2.Size = new Size(172, 46);
            label2.TabIndex = 1;
            label2.Text = "A Propos :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(195, 249);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Version :";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(195, 362);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 3;
            label4.Text = "Développé par :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(391, 249);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 4;
            label5.Text = "1 . 0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(391, 362);
            label6.Name = "label6";
            label6.Size = new Size(173, 100);
            label6.TabIndex = 5;
            label6.Text = "Antoine PISSON\r\nAntoine COUTREEL\r\nMalcolm WALTER\r\nClaire VIGUOINE\r\nTimothée L'AUMONNIER";
            // 
            // button1
            // 
            button1.Location = new Point(310, 597);
            button1.Name = "button1";
            button1.Size = new Size(227, 45);
            button1.TabIndex = 6;
            button1.Text = "RETOUR";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 694);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
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
        private Button button1;
    }
}