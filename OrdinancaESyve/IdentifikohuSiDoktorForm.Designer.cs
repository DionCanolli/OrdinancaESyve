namespace OrdinancaESyve
{
    partial class IdentifikohuSiDoktorForm
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            password = new TextBox();
            email = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(370, 477);
            button3.Name = "button3";
            button3.Size = new Size(128, 38);
            button3.TabIndex = 15;
            button3.Text = "Identifikohu si Administrator";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(460, 417);
            button2.Name = "button2";
            button2.Size = new Size(109, 35);
            button2.TabIndex = 14;
            button2.Text = "Nuk keni llogari?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(299, 417);
            button1.Name = "button1";
            button1.Size = new Size(106, 35);
            button1.TabIndex = 13;
            button1.Text = "Identifikohu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 30.25F);
            label3.Location = new Point(215, 90);
            label3.Name = "label3";
            label3.Size = new Size(414, 55);
            label3.TabIndex = 12;
            label3.Text = "Identifikohu si Doktor";
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 16F);
            password.Location = new Point(346, 313);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(205, 36);
            password.TabIndex = 11;
            // 
            // email
            // 
            email.Font = new Font("Segoe UI", 16F);
            email.Location = new Point(346, 244);
            email.Name = "email";
            email.Size = new Size(205, 36);
            email.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(215, 320);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 9;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(248, 244);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 8;
            label1.Text = "Email:";
            // 
            // IdentifikohuSiDoktor_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 611);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(password);
            Controls.Add(email);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(800, 650);
            MinimumSize = new Size(800, 650);
            Name = "IdentifikohuSiDoktor_Form";
            Text = "IdentifikohuSiDoktor_Form";
            Load += IdentifikohuSiDoktor_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Label label3;
        private TextBox password;
        private TextBox email;
        private Label label2;
        private Label label1;
    }
}