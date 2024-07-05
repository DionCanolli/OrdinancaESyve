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
    public partial class AdminDashboard : Form
    {
        private readonly OrdinancaDbContext context;
        private Administrata administratori;

        public AdminDashboard(OrdinancaDbContext context, Administrata administratori)
        {
            InitializeComponent();
            this.context = context;
            this.administratori = administratori;

            this.context.Doktori.ToList().ForEach(d =>
            {
                doktoriIZgjedhurForm.Items.Add(d.Emri);
            });

            mbushDataGridViewn();
            mbushDataGridViewn2();
            shikoRaport();
            fshijTermin();

            adminNameLabel.Text = this.administratori.Emri;

            this.FormClosed += CurrentForm_FormClosed;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void caktoTerminBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emriPacientitForm.Text)
                || string.IsNullOrEmpty(mbiemriPacientitForm.Text)
                || string.IsNullOrEmpty(nrPacientitForm.Text)
                || string.IsNullOrEmpty(moshaPacientitForm.Text))
            {
                MessageBox.Show("Mbushini te gjitha te dhenat ose kontrollo passwordin!");
            }
            else
            {
                Pacienti pacient = new Pacienti();
                pacient.Emri = emriPacientitForm.Text;
                pacient.Mbiemri = mbiemriPacientitForm.Text;
                pacient.NrTel = nrPacientitForm.Text;
                pacient.Mosha = Convert.ToInt32(moshaPacientitForm.Value);

                try
                {
                    Doktori doktori = context.Doktori
                        .Where(d => d.Emri == doktoriIZgjedhurForm.SelectedItem.ToString())
                        .FirstOrDefault();

                    if (doktori != null)
                    {
                        DateTime dataEFundit = context.Rradha
                            .OrderByDescending(e => e.KohaTakimit)
                            .Select(e => e.KohaTakimit)
                            .FirstOrDefault();
                        DateTime dataEFunditPlus30 = dataEFundit.AddMinutes(30);

                        string formattedDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        DateTime dateTime = DateTime.ParseExact
                            (formattedDateTime, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

                        try
                        {
                            Pacienti pac = this.context.Pacienti.Where(pc => pc.NrTel == pacient.NrTel
                            && pc.Mosha == pacient.Mosha).FirstOrDefault();

                            if(pac == null)
                            {
                                this.context.AddPatient(pacient);

                                if (dataEFunditPlus30 <= dateTime)
                                {
                                    Rradha rradha = new Rradha();
                                    rradha.PacientID = pacient.PacientID;
                                    rradha.DoktorID = doktori.DoktorID;
                                    rradha.KohaTakimit = dateTime;

                                    Historia historia = new Historia();
                                    historia.PacientID = pacient.PacientID;
                                    historia.DoktorID = doktori.DoktorID;
                                    historia.KohaTerminit = dateTime;

                                    this.context.Rradha.Add(rradha);
                                    this.context.Historia.Add(historia);
                                    this.context.SaveChanges();

                                    mbushDataGridViewn();
                                }
                                else
                                {
                                    Rradha rradha = new Rradha();
                                    rradha.PacientID = pacient.PacientID;
                                    rradha.DoktorID = doktori.DoktorID;
                                    rradha.KohaTakimit = dataEFunditPlus30;

                                    Historia historia = new Historia();
                                    historia.PacientID = pacient.PacientID;
                                    historia.DoktorID = doktori.DoktorID;
                                    historia.KohaTerminit = dataEFunditPlus30;

                                    this.context.Rradha.Add(rradha);
                                    this.context.Historia.Add(historia);
                                    this.context.SaveChanges();

                                    mbushDataGridViewn();
                                }
                            }
                            else
                            {
                                if (dataEFunditPlus30 <= dateTime)
                                {
                                    Rradha rradha = new Rradha();
                                    rradha.PacientID = pac.PacientID;
                                    rradha.DoktorID = doktori.DoktorID;
                                    rradha.KohaTakimit = dateTime;

                                    Historia historia = new Historia();
                                    historia.PacientID = pac.PacientID;
                                    historia.DoktorID = doktori.DoktorID;
                                    historia.KohaTerminit = dateTime;

                                    this.context.Rradha.Add(rradha);
                                    this.context.Historia.Add(historia);
                                    this.context.SaveChanges();

                                    mbushDataGridViewn();
                                }
                                else
                                {
                                    Rradha rradha = new Rradha();
                                    rradha.PacientID = pac.PacientID;
                                    rradha.DoktorID = doktori.DoktorID;
                                    rradha.KohaTakimit = dataEFunditPlus30;

                                    Historia historia = new Historia();
                                    historia.PacientID = pac.PacientID;
                                    historia.DoktorID = doktori.DoktorID;
                                    historia.KohaTerminit = dataEFunditPlus30;

                                    this.context.Rradha.Add(rradha);
                                    this.context.Historia.Add(historia);
                                    this.context.SaveChanges();

                                    mbushDataGridViewn();
                                }
                            }
                        }catch(Exception exc)
                        {
                            MessageBox.Show(exc.InnerException.ToString());
                        }

                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Selektoni doktorin tuaj!");
                    MessageBox.Show(ex.Message.ToString());
                    MessageBox.Show(ex.InnerException.ToString());
                }

            }
        }

        public void mbushDataGridViewn()
        {
            dataGridView1.Rows.Clear();

            List<Rradha> rradha = context.Rradha.ToList();

            foreach (Rradha rr in rradha)
            {
                Doktori doktori = this.context.Doktori.Where(d => d.DoktorID == rr.DoktorID).First();
                Pacienti pacienti = this.context.Pacienti.Where(p => p.PacientID == rr.PacientID).First();

                dataGridView1.Rows.Add(pacienti.Emri, pacienti.Mbiemri, pacienti.NrTel,
                    pacienti.Mosha, doktori.Emri, doktori.Email, rr.KohaTakimit, "Anulo");
            }
        }

        public void mbushDataGridViewn2()
        {
            dataGridView2.Rows.Clear();

            List<Raporti> raportet = context.Raporti.ToList();

            foreach (Raporti r in raportet)
            {
                Doktori doktori = this.context.Doktori.Where(d => d.DoktorID == r.DoktorID).First();
                Pacienti pacienti = this.context.Pacienti.Where(p => p.PacientID == r.PacientID).First();

                dataGridView2.Rows.Add(pacienti.Emri, pacienti.Mbiemri, pacienti.NrTel,
                    doktori.Emri, doktori.Email, r.KohaShkrimitRaportit, "Shiko");
            }
        }
        private void kerkoTermin_Click(object sender, EventArgs e)
        {

        }

        public void fshijTermin()
        {
            dataGridView1.CellContentClick += (sender, e) =>
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)  // Check if the column and row indices are valid
                {
                    if (dataGridView1.Columns[e.ColumnIndex].Name == "AnuloTermin")
                    {
                        // Get the data from the current row
                        var currentRow = dataGridView1.Rows[e.RowIndex];
                        string emriDoktorit = (string)currentRow.Cells["EmriDoktoritF"].Value;
                        string emailDoktorit = (string)currentRow.Cells["EmailDoktoritF"].Value;
                        string nrTelPacientit = (string)currentRow.Cells["NrPacientitF"].Value;
                        DateTime kohaETakimit = DateTime.Parse(currentRow.Cells["DataTerminitF"].Value.ToString());

                        try
                        {

                            Doktori d = context.Doktori
                                            .Where(dok => dok.Emri == emriDoktorit &&
                                                          dok.Email == emailDoktorit)
                                            .FirstOrDefault();

                            Pacienti p = context.Pacienti.Where(p => p.NrTel == nrTelPacientit).FirstOrDefault();

                            Rradha rradhaToDelete = context.Rradha
                                                        .Where(rr => rr.DoktorID == d.DoktorID &&
                                                                     rr.KohaTakimit == kohaETakimit)
                                                        .FirstOrDefault();

                            if (rradhaToDelete != null)
                            {
                                context.Rradha.Remove(rradhaToDelete);
                                context.SaveChanges();

                                // Remove the row from the DataGridView
                                dataGridView1.Rows.RemoveAt(e.RowIndex);
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

        public void shikoRaport()
        {
            dataGridView2.CellContentClick += (sender, e) =>
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)  // Check if the column and row indices are valid
                {
                    if (dataGridView2.Columns[e.ColumnIndex].Name == "ShikoRaportin")
                    {
                        // Get the data from the current row 
                        var currentRow = dataGridView2.Rows[e.RowIndex];
                        string emriPacientit = (string)currentRow.Cells["EmriPacientitR"].Value;
                        string nrTelPacientit = (string)currentRow.Cells["NrPacientitR"].Value;
                        string emriDoktorit = (string)currentRow.Cells["EmriDoktoritR"].Value;
                        string emailDoktorit = (string)currentRow.Cells["EmailDoktoritR"].Value;
                        DateTime dataRaportit = (DateTime)currentRow.Cells["DataRaportitR"].Value;

                        try
                        {
                            Pacienti p = context.Pacienti
                                            .Where(pac => pac.Emri == emriPacientit &&
                                                          pac.NrTel == nrTelPacientit)
                                            .FirstOrDefault();

                            Doktori d = context.Doktori
                                            .Where(dok => dok.Emri == emriDoktorit &&
                                                          dok.Email == emailDoktorit)
                                            .FirstOrDefault();

                            Raporti raporti = context.Raporti
                                                        .Where(rr => rr.DoktorID == d.DoktorID &&
                                                                     rr.PacientID == p.PacientID &&
                                                                     rr.KohaShkrimitRaportit == dataRaportit)
                                                        .FirstOrDefault();

                            if (raporti != null)
                            {
                                ShikoRaportin shikoRaportin =
                                    new ShikoRaportin(CreateDbConnection.makeMySqlConnection(),
                                    this.administratori, raporti);
                                shikoRaportin.Show();
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
                            MessageBox.Show("Error: " + ex.InnerException);
                        }
                    }
                }
            };
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            mbushDataGridViewn();
            mbushDataGridViewn2();
        }

        private void dilNgaLlogariaBtn_Click(object sender, EventArgs e)
        {
            IdentifikohuForm identifikohuForm = new IdentifikohuForm(CreateDbConnection.makeMySqlConnection());
            identifikohuForm.Show();
            this.Hide();
        }

        private void shikoHistorin_Click(object sender, EventArgs e)
        {

            ShikoHistorin shikoHistorin = new ShikoHistorin(CreateDbConnection.makeMySqlConnection(),
                administratori);
            shikoHistorin.Show();

            this.Hide();
        }

        private void CurrentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Exit the application when the current form is closed
        }
    }
}
