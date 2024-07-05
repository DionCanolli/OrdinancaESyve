namespace OrdinancaESyve
{
    partial class RaportForm
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
            raportiTxtBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            emriDiagnozesTxtBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            emriDoktoritLabel = new Label();
            SuspendLayout();
            // 
            // raportiTxtBox
            // 
            raportiTxtBox.Location = new Point(167, 149);
            raportiTxtBox.MaximumSize = new Size(500, 450);
            raportiTxtBox.MinimumSize = new Size(500, 450);
            raportiTxtBox.Multiline = true;
            raportiTxtBox.Name = "raportiTxtBox";
            raportiTxtBox.Size = new Size(500, 450);
            raportiTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(12, 149);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 1;
            label1.Text = "Raporti:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 2;
            label2.Text = "Emri i Diagnozes:";
            // 
            // emriDiagnozesTxtBox
            // 
            emriDiagnozesTxtBox.Font = new Font("Segoe UI", 15F);
            emriDiagnozesTxtBox.Location = new Point(167, 93);
            emriDiagnozesTxtBox.Name = "emriDiagnozesTxtBox";
            emriDiagnozesTxtBox.Size = new Size(246, 34);
            emriDiagnozesTxtBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(272, 625);
            button1.Name = "button1";
            button1.Size = new Size(135, 45);
            button1.TabIndex = 4;
            button1.Text = "Shkruaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(445, 625);
            button2.Name = "button2";
            button2.Size = new Size(135, 45);
            button2.TabIndex = 5;
            button2.Text = "Kthehu pas";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // emriDoktoritLabel
            // 
            emriDoktoritLabel.AutoSize = true;
            emriDoktoritLabel.Font = new Font("Segoe UI", 15F);
            emriDoktoritLabel.Location = new Point(677, 30);
            emriDoktoritLabel.Name = "emriDoktoritLabel";
            emriDoktoritLabel.Size = new Size(24, 28);
            emriDoktoritLabel.TabIndex = 6;
            emriDoktoritLabel.Text = "d";
            // 
            // Raport_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 712);
            Controls.Add(emriDoktoritLabel);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(emriDiagnozesTxtBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(raportiTxtBox);
            Name = "Raport_Form";
            Text = "Raport_Form";
            Load += Raport_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox raportiTxtBox;
        private Label label1;
        private Label label2;
        private TextBox emriDiagnozesTxtBox;
        private Button button1;
        private Button button2;
        private Label emriDoktoritLabel;
    }
}