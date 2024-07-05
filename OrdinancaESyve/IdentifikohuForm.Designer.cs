namespace OrdinancaESyve
{
    partial class IdentifikohuForm
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
            email = new TextBox();
            password = new TextBox();
            label3 = new Label();
            identifikohu = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(226, 194);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(193, 270);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // email
            // 
            email.Font = new Font("Segoe UI", 16F);
            email.Location = new Point(324, 194);
            email.Name = "email";
            email.Size = new Size(205, 36);
            email.TabIndex = 2;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 16F);
            password.Location = new Point(324, 263);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(205, 36);
            password.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 30.25F);
            label3.Location = new Point(147, 51);
            label3.Name = "label3";
            label3.Size = new Size(535, 55);
            label3.TabIndex = 4;
            label3.Text = "Identifikohu si Administrator";
            // 
            // identifikohu
            // 
            identifikohu.Location = new Point(277, 367);
            identifikohu.Name = "identifikohu";
            identifikohu.Size = new Size(106, 35);
            identifikohu.TabIndex = 5;
            identifikohu.Text = "Identifikohu";
            identifikohu.UseVisualStyleBackColor = true;
            identifikohu.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(438, 367);
            button2.Name = "button2";
            button2.Size = new Size(109, 35);
            button2.TabIndex = 6;
            button2.Text = "Nuk keni llogari?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(348, 427);
            button3.Name = "button3";
            button3.Size = new Size(128, 38);
            button3.TabIndex = 7;
            button3.Text = "Identifikohu si doktor";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // IdentifikohuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 609);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(identifikohu);
            Controls.Add(label3);
            Controls.Add(password);
            Controls.Add(email);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(800, 648);
            MinimumSize = new Size(800, 648);
            Name = "IdentifikohuForm";
            Text = "Identifikohu_Form";
            Load += Identifikohu_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox email;
        private TextBox password;
        private Label label3;
        private Button identifikohu;
        private Button button2;
        private Button button3;
    }
}