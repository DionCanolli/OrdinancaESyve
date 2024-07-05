namespace OrdinancaESyve
{
    partial class ShikoRaportin
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
            emriDoktoritTxtBox = new TextBox();
            emriDiagnozesTxtBox = new TextBox();
            raportiTxtBox = new TextBox();
            emriAdminit = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(104, 45);
            label1.Name = "label1";
            label1.Size = new Size(83, 28);
            label1.TabIndex = 0;
            label1.Text = "Doktori:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(26, 97);
            label2.Name = "label2";
            label2.Size = new Size(161, 28);
            label2.TabIndex = 1;
            label2.Text = "Emri i Diagnozes:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(104, 154);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 2;
            label3.Text = "Raporti:";
            // 
            // emriDoktoritTxtBox
            // 
            emriDoktoritTxtBox.Font = new Font("Segoe UI", 15F);
            emriDoktoritTxtBox.Location = new Point(220, 45);
            emriDoktoritTxtBox.Name = "emriDoktoritTxtBox";
            emriDoktoritTxtBox.Size = new Size(186, 34);
            emriDoktoritTxtBox.TabIndex = 3;
            emriDoktoritTxtBox.TextChanged += textBox1_TextChanged;
            // 
            // emriDiagnozesTxtBox
            // 
            emriDiagnozesTxtBox.Font = new Font("Segoe UI", 15F);
            emriDiagnozesTxtBox.Location = new Point(220, 97);
            emriDiagnozesTxtBox.Name = "emriDiagnozesTxtBox";
            emriDiagnozesTxtBox.Size = new Size(186, 34);
            emriDiagnozesTxtBox.TabIndex = 4;
            // 
            // raportiTxtBox
            // 
            raportiTxtBox.Location = new Point(220, 162);
            raportiTxtBox.MaximumSize = new Size(500, 400);
            raportiTxtBox.MinimumSize = new Size(500, 400);
            raportiTxtBox.Multiline = true;
            raportiTxtBox.Name = "raportiTxtBox";
            raportiTxtBox.Size = new Size(500, 400);
            raportiTxtBox.TabIndex = 5;
            // 
            // emriAdminit
            // 
            emriAdminit.AutoSize = true;
            emriAdminit.Font = new Font("Segoe UI", 15F);
            emriAdminit.Location = new Point(700, 28);
            emriAdminit.Name = "emriAdminit";
            emriAdminit.Size = new Size(65, 28);
            emriAdminit.TabIndex = 6;
            emriAdminit.Text = "label4";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(457, 595);
            button1.Name = "button1";
            button1.Size = new Size(130, 37);
            button1.TabIndex = 7;
            button1.Text = "Kthehu Pas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(323, 595);
            button2.Name = "button2";
            button2.Size = new Size(128, 37);
            button2.TabIndex = 8;
            button2.Text = "Printo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ShikoRaportin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 661);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(emriAdminit);
            Controls.Add(raportiTxtBox);
            Controls.Add(emriDiagnozesTxtBox);
            Controls.Add(emriDoktoritTxtBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ShikoRaportin";
            Text = "ShikoRaportin";
            Load += ShikoRaportin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox emriDoktoritTxtBox;
        private TextBox emriDiagnozesTxtBox;
        private TextBox raportiTxtBox;
        private Label emriAdminit;
        private Button button1;
        private Button button2;
    }
}