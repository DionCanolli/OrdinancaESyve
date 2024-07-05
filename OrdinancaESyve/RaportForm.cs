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
    public partial class RaportForm : Form
    {
        private readonly OrdinancaDbContext context;
        private Doktori doktoriIRegjistruar;
        Rradha rradhaEGjetur;
        Pacienti pacienti;

        public RaportForm(OrdinancaDbContext context, Doktori doktoriIRegjistruar,
            Pacienti pacienti, Rradha rradhaEGjetur)
        {
            InitializeComponent();
            this.context = context;
            this.doktoriIRegjistruar = doktoriIRegjistruar;
            this.rradhaEGjetur = rradhaEGjetur;
            this.pacienti = pacienti;

            emriDoktoritLabel.Text = doktoriIRegjistruar.Emri;
            this.FormClosed += CurrentForm_FormClosed;
        }

        private void Raport_Form_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoktorDashboard doktorDashboardForm = new DoktorDashboard(CreateDbConnection.makeMySqlConnection(), doktoriIRegjistruar);
            doktorDashboardForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.context.Rradha.Remove(rradhaEGjetur);

            Raporti raporti = new Raporti();
            raporti.PacientID = pacienti.PacientID;
            raporti.DoktorID = doktoriIRegjistruar.DoktorID;
            raporti.EmriDiagnozes = emriDiagnozesTxtBox.Text;
            raporti.PershkrimiDiagnozes = raportiTxtBox.Text;

            string formattedDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            DateTime dateTime = DateTime.ParseExact
                (formattedDateTime, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            raporti.KohaShkrimitRaportit = dateTime;

            this.context.Raporti.Add(raporti);
            context.SaveChanges();

            DoktorDashboard doktorDashboardForm = new DoktorDashboard(CreateDbConnection.makeMySqlConnection(), doktoriIRegjistruar);
            doktorDashboardForm.Show();
            this.Hide();
        }

        private void CurrentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Exit the application when the current form is closed
        }
    }
}
