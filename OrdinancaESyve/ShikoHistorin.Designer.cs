namespace OrdinancaESyve
{
    partial class ShikoHistorin
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
            kthehuPas = new Button();
            dataGridView1 = new DataGridView();
            EmriPacientit = new DataGridViewTextBoxColumn();
            MbiemriPacientit = new DataGridViewTextBoxColumn();
            NrTelPacientit = new DataGridViewTextBoxColumn();
            MoshaPacientit = new DataGridViewTextBoxColumn();
            EmriDoktorit = new DataGridViewTextBoxColumn();
            MbiemriDoktorit = new DataGridViewTextBoxColumn();
            EmailDoktorit = new DataGridViewTextBoxColumn();
            KohaTerminit = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // kthehuPas
            // 
            kthehuPas.Font = new Font("Segoe UI", 14F);
            kthehuPas.Location = new Point(406, 538);
            kthehuPas.Name = "kthehuPas";
            kthehuPas.Size = new Size(122, 33);
            kthehuPas.TabIndex = 0;
            kthehuPas.Text = "Kthehu pas";
            kthehuPas.UseVisualStyleBackColor = true;
            kthehuPas.Click += kthehuPas_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EmriPacientit, MbiemriPacientit, NrTelPacientit, MoshaPacientit, EmriDoktorit, MbiemriDoktorit, EmailDoktorit, KohaTerminit });
            dataGridView1.Location = new Point(7, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(920, 475);
            dataGridView1.TabIndex = 1;
            // 
            // EmriPacientit
            // 
            EmriPacientit.HeaderText = "Emri i Pacientit";
            EmriPacientit.Name = "EmriPacientit";
            EmriPacientit.ReadOnly = true;
            EmriPacientit.Width = 105;
            // 
            // MbiemriPacientit
            // 
            MbiemriPacientit.HeaderText = "Mbiemri i Pacientit";
            MbiemriPacientit.Name = "MbiemriPacientit";
            MbiemriPacientit.ReadOnly = true;
            MbiemriPacientit.Width = 105;
            // 
            // NrTelPacientit
            // 
            NrTelPacientit.HeaderText = "Nr. Tel. i Pacientit";
            NrTelPacientit.Name = "NrTelPacientit";
            NrTelPacientit.ReadOnly = true;
            NrTelPacientit.Width = 105;
            // 
            // MoshaPacientit
            // 
            MoshaPacientit.HeaderText = "Mosha e Pacientit";
            MoshaPacientit.Name = "MoshaPacientit";
            MoshaPacientit.ReadOnly = true;
            MoshaPacientit.Width = 105;
            // 
            // EmriDoktorit
            // 
            EmriDoktorit.HeaderText = "Emri i Doktorit";
            EmriDoktorit.Name = "EmriDoktorit";
            EmriDoktorit.ReadOnly = true;
            EmriDoktorit.Width = 105;
            // 
            // MbiemriDoktorit
            // 
            MbiemriDoktorit.HeaderText = "Mbiemri i Doktorit";
            MbiemriDoktorit.Name = "MbiemriDoktorit";
            MbiemriDoktorit.ReadOnly = true;
            MbiemriDoktorit.Width = 105;
            // 
            // EmailDoktorit
            // 
            EmailDoktorit.HeaderText = "Email e Doktorit";
            EmailDoktorit.Name = "EmailDoktorit";
            EmailDoktorit.ReadOnly = true;
            EmailDoktorit.Width = 115;
            // 
            // KohaTerminit
            // 
            KohaTerminit.HeaderText = "Koha e Terminit";
            KohaTerminit.Name = "KohaTerminit";
            KohaTerminit.ReadOnly = true;
            KohaTerminit.Width = 130;
            // 
            // ShikoHistorin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 611);
            Controls.Add(dataGridView1);
            Controls.Add(kthehuPas);
            MaximumSize = new Size(950, 650);
            MinimumSize = new Size(950, 650);
            Name = "ShikoHistorin";
            Text = "ShikoHistorin";
            Load += ShikoHistorin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button kthehuPas;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn EmriPacientit;
        private DataGridViewTextBoxColumn MbiemriPacientit;
        private DataGridViewTextBoxColumn NrTelPacientit;
        private DataGridViewTextBoxColumn MoshaPacientit;
        private DataGridViewTextBoxColumn EmriDoktorit;
        private DataGridViewTextBoxColumn MbiemriDoktorit;
        private DataGridViewTextBoxColumn EmailDoktorit;
        private DataGridViewTextBoxColumn KohaTerminit;
    }
}