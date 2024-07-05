namespace OrdinancaESyve
{
    partial class RegisterForm
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
            emriTextBox = new TextBox();
            mbiemriTextBox = new TextBox();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            konfirmoPasswordinTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            regjistroButton = new Button();
            keniLlogariButton = new Button();
            navigoTeRegjistroSiPacientButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(147, 31);
            label1.Name = "label1";
            label1.Size = new Size(517, 54);
            label1.TabIndex = 0;
            label1.Text = "Regjistrohu si Administrator";
            // 
            // emriTextBox
            // 
            emriTextBox.Font = new Font("Segoe UI", 16F);
            emriTextBox.ForeColor = SystemColors.WindowText;
            emriTextBox.Location = new Point(279, 153);
            emriTextBox.Name = "emriTextBox";
            emriTextBox.Size = new Size(263, 36);
            emriTextBox.TabIndex = 1;
            // 
            // mbiemriTextBox
            // 
            mbiemriTextBox.Font = new Font("Segoe UI", 16F);
            mbiemriTextBox.Location = new Point(279, 204);
            mbiemriTextBox.Name = "mbiemriTextBox";
            mbiemriTextBox.Size = new Size(263, 36);
            mbiemriTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 16F);
            emailTextBox.Location = new Point(279, 253);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(263, 36);
            emailTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 16F);
            passwordTextBox.Location = new Point(279, 306);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(263, 36);
            passwordTextBox.TabIndex = 4;
            // 
            // konfirmoPasswordinTextBox
            // 
            konfirmoPasswordinTextBox.Font = new Font("Segoe UI", 16F);
            konfirmoPasswordinTextBox.Location = new Point(279, 357);
            konfirmoPasswordinTextBox.Name = "konfirmoPasswordinTextBox";
            konfirmoPasswordinTextBox.PasswordChar = '*';
            konfirmoPasswordinTextBox.Size = new Size(263, 36);
            konfirmoPasswordinTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(168, 159);
            label2.Name = "label2";
            label2.Size = new Size(54, 26);
            label2.TabIndex = 7;
            label2.Text = "Emri:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(168, 211);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 8;
            label3.Text = "Mbiemri:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(168, 260);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 9;
            label4.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(168, 313);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 11;
            label6.Text = "Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(85, 364);
            label7.Name = "label7";
            label7.Size = new Size(179, 25);
            label7.TabIndex = 12;
            label7.Text = "Konfirmo password:";
            // 
            // regjistroButton
            // 
            regjistroButton.Location = new Point(282, 446);
            regjistroButton.Name = "regjistroButton";
            regjistroButton.Size = new Size(121, 41);
            regjistroButton.TabIndex = 13;
            regjistroButton.Text = "Regjistrohu";
            regjistroButton.UseVisualStyleBackColor = true;
            regjistroButton.Click += regjistroButton_Click;
            // 
            // keniLlogariButton
            // 
            keniLlogariButton.Location = new Point(420, 446);
            keniLlogariButton.Name = "keniLlogariButton";
            keniLlogariButton.Size = new Size(113, 41);
            keniLlogariButton.TabIndex = 14;
            keniLlogariButton.Text = "Keni llogari?";
            keniLlogariButton.UseVisualStyleBackColor = true;
            keniLlogariButton.Click += keniLlogariButton_Click;
            // 
            // navigoTeRegjistroSiPacientButton
            // 
            navigoTeRegjistroSiPacientButton.Location = new Point(357, 518);
            navigoTeRegjistroSiPacientButton.Name = "navigoTeRegjistroSiPacientButton";
            navigoTeRegjistroSiPacientButton.Size = new Size(118, 41);
            navigoTeRegjistroSiPacientButton.TabIndex = 15;
            navigoTeRegjistroSiPacientButton.Text = "Regjistrohu si Doktor";
            navigoTeRegjistroSiPacientButton.UseVisualStyleBackColor = true;
            navigoTeRegjistroSiPacientButton.Click += navigoTeRegjistroSiDoktorButton_Click;
            // 
            // Register_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 611);
            Controls.Add(navigoTeRegjistroSiPacientButton);
            Controls.Add(keniLlogariButton);
            Controls.Add(regjistroButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(konfirmoPasswordinTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(mbiemriTextBox);
            Controls.Add(emriTextBox);
            Controls.Add(label1);
            MaximumSize = new Size(800, 650);
            MinimumSize = new Size(800, 650);
            Name = "Register_Form";
            Text = "Register_Form";
            Load += Register_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox emriTextBox;
        private TextBox mbiemriTextBox;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private TextBox konfirmoPasswordinTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Button regjistroButton;
        private Button keniLlogariButton;
        private Button navigoTeRegjistroSiPacientButton;
    }
}