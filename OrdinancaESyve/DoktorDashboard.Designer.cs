namespace OrdinancaESyve
{
    partial class DoktorDashboard
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
            emriDoktoritLabel = new Label();
            dilNgaLlogaria = new Button();
            kthehuPas = new Button();
            dataGridView1 = new DataGridView();
            EmriPacientit = new DataGridViewTextBoxColumn();
            NrTelPacientit = new DataGridViewTextBoxColumn();
            DataTakimit = new DataGridViewTextBoxColumn();
            ShkruajRaport = new DataGridViewButtonColumn();
            refresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // emriDoktoritLabel
            // 
            emriDoktoritLabel.AutoSize = true;
            emriDoktoritLabel.Font = new Font("Segoe UI", 15F);
            emriDoktoritLabel.Location = new Point(742, 35);
            emriDoktoritLabel.Name = "emriDoktoritLabel";
            emriDoktoritLabel.Size = new Size(65, 28);
            emriDoktoritLabel.TabIndex = 0;
            emriDoktoritLabel.Text = "label1";
            // 
            // dilNgaLlogaria
            // 
            dilNgaLlogaria.Font = new Font("Segoe UI", 15F);
            dilNgaLlogaria.Location = new Point(694, 75);
            dilNgaLlogaria.Name = "dilNgaLlogaria";
            dilNgaLlogaria.Size = new Size(157, 38);
            dilNgaLlogaria.TabIndex = 1;
            dilNgaLlogaria.Text = "Dil nga llogaria";
            dilNgaLlogaria.UseVisualStyleBackColor = true;
            dilNgaLlogaria.Click += dilNgaLlogaria_Click;
            // 
            // kthehuPas
            // 
            kthehuPas.Font = new Font("Segoe UI", 15F);
            kthehuPas.Location = new Point(388, 527);
            kthehuPas.Name = "kthehuPas";
            kthehuPas.Size = new Size(137, 39);
            kthehuPas.TabIndex = 2;
            kthehuPas.Text = "Kthehu Pas";
            kthehuPas.UseVisualStyleBackColor = true;
            kthehuPas.Click += kthehuPas_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EmriPacientit, NrTelPacientit, DataTakimit, ShkruajRaport });
            dataGridView1.Location = new Point(26, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(843, 341);
            dataGridView1.TabIndex = 3;
            // 
            // EmriPacientit
            // 
            EmriPacientit.HeaderText = "Pacienti";
            EmriPacientit.Name = "EmriPacientit";
            EmriPacientit.ReadOnly = true;
            EmriPacientit.Width = 200;
            // 
            // NrTelPacientit
            // 
            NrTelPacientit.HeaderText = "Nr. Tel. i Pacientit";
            NrTelPacientit.Name = "NrTelPacientit";
            NrTelPacientit.ReadOnly = true;
            NrTelPacientit.Width = 200;
            // 
            // DataTakimit
            // 
            DataTakimit.HeaderText = "Data e Takimit";
            DataTakimit.Name = "DataTakimit";
            DataTakimit.ReadOnly = true;
            DataTakimit.Width = 200;
            // 
            // ShkruajRaport
            // 
            ShkruajRaport.HeaderText = "Shkruaj Raport";
            ShkruajRaport.Name = "ShkruajRaport";
            ShkruajRaport.ReadOnly = true;
            ShkruajRaport.Width = 200;
            // 
            // refresh
            // 
            refresh.Location = new Point(418, 87);
            refresh.Name = "refresh";
            refresh.Size = new Size(75, 23);
            refresh.TabIndex = 4;
            refresh.Text = "Refresh";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += refresh_Click;
            // 
            // DoktorDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 661);
            Controls.Add(refresh);
            Controls.Add(dataGridView1);
            Controls.Add(kthehuPas);
            Controls.Add(dilNgaLlogaria);
            Controls.Add(emriDoktoritLabel);
            MaximumSize = new Size(900, 700);
            MinimumSize = new Size(900, 700);
            Name = "DoktorDashboard";
            Text = "ShkruajRaport_Form";
            Load += ShkruajRaport_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label emriDoktoritLabel;
        private Button dilNgaLlogaria;
        private Button kthehuPas;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn EmriPacientit;
        private DataGridViewTextBoxColumn NrTelPacientit;
        private DataGridViewTextBoxColumn DataTakimit;
        private DataGridViewButtonColumn ShkruajRaport;
        private Button refresh;
    }
}