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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OrdinancaESyve
{
    public partial class IdentifikohuSiDoktorForm : Form
    {
        OrdinancaDbContext context;
        public IdentifikohuSiDoktorForm(OrdinancaDbContext context)
        {
            InitializeComponent();
            this.context = context;
            this.FormClosed += CurrentForm_FormClosed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doktori doktori = context.Doktori.Where(d => d.Email == email.Text).FirstOrDefault();

            if (string.IsNullOrEmpty(email.Text)
                || string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("Mbushini te gjitha te dhenat ose kontrollo passwordin!");
            }
            else if (doktori == null)
            {
                MessageBox.Show("Pacienti me kete email nuk egziston!");
            }
            else
            {
                if (HashPassword.Compare(password.Text, doktori.Password))
                {
                    DoktorDashboard doktorDashboardForm = new DoktorDashboard(CreateDbConnection.makeMySqlConnection(), doktori);
                    doktorDashboardForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Gabim Passwordi!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IdentifikohuForm identifikohuForm =
                new IdentifikohuForm(CreateDbConnection.makeMySqlConnection());
            identifikohuForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegjistrohuSiDoktorForm regjistrohuForm =
                new RegjistrohuSiDoktorForm(CreateDbConnection.makeMySqlConnection());
            regjistrohuForm.Show();
            this.Hide();
        }

        private void IdentifikohuSiDoktor_Form_Load(object sender, EventArgs e)
        {

        }

        private void CurrentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Exit the application when the current form is closed
        }
    }
}
