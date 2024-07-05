using OrdinancaESyve.Data;
using OrdinancaESyve.Model;
using OrdinancaESyve.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdinancaESyve
{
    public partial class DoktorDashboard : Form
    {
        private readonly OrdinancaDbContext context;
        private Doktori doktoriIRegjistruar;
        private List<Rradha> rradha;
        List<RradhaDTO> rradhaDTOList = new List<RradhaDTO>();

        public DoktorDashboard(OrdinancaDbContext context, Doktori doktoriIRegjistruar)
        {
            InitializeComponent();
            this.context = context;
            this.doktoriIRegjistruar = doktoriIRegjistruar;
            emriDoktoritLabel.Text = doktoriIRegjistruar.Emri;
            this.FormClosed += CurrentForm_FormClosed;

            try
            {
                mbushDataGridViewn();

                // Kjo sherben me ju qas buttonit te selektuar na naj rresht te datagridview, dhe
                // me fshi ate takim nga tabela rradha, ne baz te doktorit dhe takimit te marr nga 
                // emri i doktorit dhe takimi
                dataGridView1.CellContentClick += (sender, e) =>
                {
                    if (e.ColumnIndex >= 0 && e.RowIndex >= 0)  // Check if the column and row indices are valid
                    {
                        if (dataGridView1.Columns[e.ColumnIndex].Name == "ShkruajRaport")
                        {
                            // Get the data from the current row
                            var currentRow = dataGridView1.Rows[e.RowIndex];
                            string emriPacientit = (string)currentRow.Cells["EmriPacientit"].Value;
                            string nrTelPacientit = (string)currentRow.Cells["NrTelPacientit"].Value;
                            DateTime dataTakimit = (DateTime)currentRow.Cells["DataTakimit"].Value;

                            try
                            {
                                Pacienti p = context.Pacienti
                                                .Where(pac => pac.Emri == emriPacientit &&
                                                              pac.NrTel == nrTelPacientit)
                                                .FirstOrDefault();

                                Rradha rradha = context.Rradha
                                                            .Where(rr => rr.DoktorID == doktoriIRegjistruar.DoktorID &&
                                                                         rr.PacientID == p.PacientID &&
                                                                         rr.KohaTakimit == dataTakimit)
                                                            .FirstOrDefault();

                                if (rradha != null)
                                {
                                    RaportForm raportForm =
                                        new RaportForm(CreateDbConnection.makeMySqlConnection(),
                                        doktoriIRegjistruar, p, rradha);
                                    raportForm.Show();
                                    this.Hide();

                                }
                                else
                                {
                                    MessageBox.Show("Error");

                                }

                            }
                            catch (Exception ex)
                            {
                                // Handle exception
                                MessageBox.Show("Error: " + ex.Message);
                            }
                        }
                    }
                };

            }
            catch (Exception ex)
            {
                this.rradha = null;
            }
        }

        private void ShkruajRaport_Form_Load(object sender, EventArgs e)
        {

        }

        private void dilNgaLlogaria_Click(object sender, EventArgs e)
        {
            IdentifikohuSiDoktorForm identifikohuSiDoktorForm =
                new IdentifikohuSiDoktorForm(CreateDbConnection.makeMySqlConnection());
            identifikohuSiDoktorForm.Show();
            this.Hide();
        }

        private void kthehuPas_Click(object sender, EventArgs e)
        {
            IdentifikohuSiDoktorForm doktorDashboardForm =
                new IdentifikohuSiDoktorForm(CreateDbConnection.makeMySqlConnection());
            doktorDashboardForm.Show();
            this.Hide();
        }

        public void mbushDataGridViewn()
        {
            this.rradha = context.Rradha
                  .Where(rr => rr.DoktorID == doktoriIRegjistruar.DoktorID).ToList();


            foreach (Rradha rr in this.rradha)
            {
                Doktori doktori = this.context.Doktori.Where(d => d.DoktorID == rr.DoktorID).First();
                Pacienti pacienti = this.context.Pacienti.Where(p => p.PacientID == rr.PacientID).First();

                dataGridView1.Rows.Add(pacienti.Emri, pacienti.NrTel, rr.KohaTakimit, "Shkruaj Raport");

            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            mbushDataGridViewn();
        }

        private void CurrentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Exit the application when the current form is closed
        }
    }
}
