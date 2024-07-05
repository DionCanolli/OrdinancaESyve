using OrdinancaESyve.Data;
using OrdinancaESyve.Model;
using OrdinancaESyve.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdinancaESyve
{
    public partial class ShikoRaportin : Form
    {
        private readonly OrdinancaDbContext context;
        private Raporti raporti;
        private Administrata administrata;

        public ShikoRaportin(OrdinancaDbContext context, Administrata administrata, Raporti raporti)
        {
            InitializeComponent();
            this.context = context;
            this.raporti = raporti;
            this.administrata = administrata;

            Doktori d = this.context.Doktori.Where(dok => dok.DoktorID == raporti.DoktorID).FirstOrDefault();
            Pacienti p = this.context.Pacienti.Where(pac => pac.PacientID == raporti.PacientID).FirstOrDefault();

            emriDoktoritTxtBox.Text = d.Emri;
            emriDiagnozesTxtBox.Text = raporti.EmriDiagnozes;
            raportiTxtBox.Text = raporti.PershkrimiDiagnozes;
            emriDoktoritTxtBox.ReadOnly = true;
            emriDiagnozesTxtBox.ReadOnly = true;
            raportiTxtBox.ReadOnly = true;

            emriAdminit.Text = this.administrata.Emri;
            this.FormClosed += CurrentForm_FormClosed;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboard shikoRaportet =
                new AdminDashboard(CreateDbConnection.makeMySqlConnection(), administrata);
            shikoRaportet.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ShikoRaportin_Load(object sender, EventArgs e)
        {

        }

        private void CurrentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Exit the application when the current form is closed
        }
    }
}
