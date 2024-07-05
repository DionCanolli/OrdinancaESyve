namespace OrdinancaESyve
{
    partial class RegjistrohuSiDoktorForm
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
            keniLlogariButton = new Button();
            regjistroDoktorButton = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            moshaDoktoritNumericBox = new NumericUpDown();
            konfirmoDoktoritPasswordinTextBox = new TextBox();
            passwordDoktoritTextBox = new TextBox();
            emailDoktoritTextBox = new TextBox();
            mbiemriDoktoritTextBox = new TextBox();
            emriDoktoritTextBox = new TextBox();
            label1 = new Label();
            label8 = new Label();
            klinika_prishtine = new RadioButton();
            klinika_prizren = new RadioButton();
            navigoTeRegister = new Button();
            ((System.ComponentModel.ISupportInitialize)moshaDoktoritNumericBox).BeginInit();
            SuspendLayout();
            // 
            // keniLlogariButton
            // 
            keniLlogariButton.Location = new Point(294, 527);
            keniLlogariButton.Name = "keniLlogariButton";
            keniLlogariButton.Size = new Size(113, 41);
            keniLlogariButton.TabIndex = 30;
            keniLlogariButton.Text = "Keni llogari?";
            keniLlogariButton.UseVisualStyleBackColor = true;
            keniLlogariButton.Click += keniLlogariButton_Click;
            // 
            // regjistroDoktorButton
            // 
            regjistroDoktorButton.Location = new Point(363, 448);
            regjistroDoktorButton.Name = "regjistroDoktorButton";
            regjistroDoktorButton.Size = new Size(121, 33);
            regjistroDoktorButton.TabIndex = 29;
            regjistroDoktorButton.Text = "Regjistro";
            regjistroDoktorButton.UseVisualStyleBackColor = true;
            regjistroDoktorButton.Click += regjistroDoktorButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(97, 391);
            label7.Name = "label7";
            label7.Size = new Size(179, 25);
            label7.TabIndex = 28;
            label7.Text = "Konfirmo password:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(180, 340);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 27;
            label6.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(169, 295);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 26;
            label5.Text = "Mosha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(180, 247);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 25;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(180, 198);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 24;
            label3.Text = "Mbiemri:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(180, 146);
            label2.Name = "label2";
            label2.Size = new Size(54, 26);
            label2.TabIndex = 23;
            label2.Text = "Emri:";
            // 
            // moshaDoktoritNumericBox
            // 
            moshaDoktoritNumericBox.Location = new Point(258, 295);
            moshaDoktoritNumericBox.Name = "moshaDoktoritNumericBox";
            moshaDoktoritNumericBox.Size = new Size(134, 23);
            moshaDoktoritNumericBox.TabIndex = 22;
            moshaDoktoritNumericBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // konfirmoDoktoritPasswordinTextBox
            // 
            konfirmoDoktoritPasswordinTextBox.Font = new Font("Segoe UI", 16F);
            konfirmoDoktoritPasswordinTextBox.Location = new Point(291, 384);
            konfirmoDoktoritPasswordinTextBox.Name = "konfirmoDoktoritPasswordinTextBox";
            konfirmoDoktoritPasswordinTextBox.PasswordChar = '*';
            konfirmoDoktoritPasswordinTextBox.Size = new Size(263, 36);
            konfirmoDoktoritPasswordinTextBox.TabIndex = 21;
            // 
            // passwordDoktoritTextBox
            // 
            passwordDoktoritTextBox.Font = new Font("Segoe UI", 16F);
            passwordDoktoritTextBox.Location = new Point(291, 333);
            passwordDoktoritTextBox.Name = "passwordDoktoritTextBox";
            passwordDoktoritTextBox.PasswordChar = '*';
            passwordDoktoritTextBox.Size = new Size(263, 36);
            passwordDoktoritTextBox.TabIndex = 20;
            // 
            // emailDoktoritTextBox
            // 
            emailDoktoritTextBox.Font = new Font("Segoe UI", 16F);
            emailDoktoritTextBox.Location = new Point(291, 240);
            emailDoktoritTextBox.Name = "emailDoktoritTextBox";
            emailDoktoritTextBox.Size = new Size(263, 36);
            emailDoktoritTextBox.TabIndex = 19;
            // 
            // mbiemriDoktoritTextBox
            // 
            mbiemriDoktoritTextBox.Font = new Font("Segoe UI", 16F);
            mbiemriDoktoritTextBox.Location = new Point(291, 191);
            mbiemriDoktoritTextBox.Name = "mbiemriDoktoritTextBox";
            mbiemriDoktoritTextBox.Size = new Size(263, 36);
            mbiemriDoktoritTextBox.TabIndex = 18;
            // 
            // emriDoktoritTextBox
            // 
            emriDoktoritTextBox.Font = new Font("Segoe UI", 16F);
            emriDoktoritTextBox.ForeColor = SystemColors.WindowText;
            emriDoktoritTextBox.Location = new Point(291, 140);
            emriDoktoritTextBox.Name = "emriDoktoritTextBox";
            emriDoktoritTextBox.Size = new Size(263, 36);
            emriDoktoritTextBox.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(225, 23);
            label1.Name = "label1";
            label1.Size = new Size(396, 54);
            label1.TabIndex = 16;
            label1.Text = "Regjistrohu si Doktor";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(426, 293);
            label8.Name = "label8";
            label8.Size = new Size(72, 25);
            label8.TabIndex = 33;
            label8.Text = "Klinika:";
            // 
            // klinika_prishtine
            // 
            klinika_prishtine.AutoSize = true;
            klinika_prishtine.Location = new Point(513, 295);
            klinika_prishtine.Name = "klinika_prishtine";
            klinika_prishtine.Size = new Size(71, 19);
            klinika_prishtine.TabIndex = 34;
            klinika_prishtine.TabStop = true;
            klinika_prishtine.Text = "Prishtine";
            klinika_prishtine.UseVisualStyleBackColor = true;
            klinika_prishtine.CheckedChanged += klinika_prishtine_CheckedChanged;
            // 
            // klinika_prizren
            // 
            klinika_prizren.AutoSize = true;
            klinika_prizren.Location = new Point(605, 295);
            klinika_prizren.Name = "klinika_prizren";
            klinika_prizren.Size = new Size(61, 19);
            klinika_prizren.TabIndex = 35;
            klinika_prizren.TabStop = true;
            klinika_prizren.Text = "Prizren";
            klinika_prizren.UseVisualStyleBackColor = true;
            klinika_prizren.CheckedChanged += klinika_prizren_CheckedChanged;
            // 
            // navigoTeRegister
            // 
            navigoTeRegister.Location = new Point(426, 528);
            navigoTeRegister.Name = "navigoTeRegister";
            navigoTeRegister.Size = new Size(120, 40);
            navigoTeRegister.TabIndex = 36;
            navigoTeRegister.Text = "Regjistrohu si Administrator";
            navigoTeRegister.UseVisualStyleBackColor = true;
            navigoTeRegister.Click += navigoTeRegister_Click;
            // 
            // RegjistrohuSiDoktorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 611);
            Controls.Add(navigoTeRegister);
            Controls.Add(klinika_prizren);
            Controls.Add(klinika_prishtine);
            Controls.Add(label8);
            Controls.Add(keniLlogariButton);
            Controls.Add(regjistroDoktorButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(moshaDoktoritNumericBox);
            Controls.Add(konfirmoDoktoritPasswordinTextBox);
            Controls.Add(passwordDoktoritTextBox);
            Controls.Add(emailDoktoritTextBox);
            Controls.Add(mbiemriDoktoritTextBox);
            Controls.Add(emriDoktoritTextBox);
            Controls.Add(label1);
            MaximumSize = new Size(800, 650);
            MinimumSize = new Size(800, 650);
            Name = "RegjistrohuSiDoktorForm";
            Text = "RegjistrohuSiDoktor_Form";
            Load += RegjistrohuSiDoktorForm_Load;
            ((System.ComponentModel.ISupportInitialize)moshaDoktoritNumericBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button keniLlogariButton;
        private Button regjistroDoktorButton;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown moshaDoktoritNumericBox;
        private TextBox konfirmoDoktoritPasswordinTextBox;
        private TextBox passwordDoktoritTextBox;
        private TextBox emailDoktoritTextBox;
        private TextBox mbiemriDoktoritTextBox;
        private TextBox emriDoktoritTextBox;
        private Label label1;
        private Label label8;
        private RadioButton klinika_prishtine;
        private RadioButton klinika_prizren;
        private Button navigoTeRegister;
    }
}