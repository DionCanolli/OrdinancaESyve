using OrdinancaESyve.Data;
using OrdinancaESyve.Model;
using OrdinancaESyve.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdinancaESyve
{
    public partial class IdentifikohuForm : Form
    {
        private readonly OrdinancaDbContext context;
        public IdentifikohuForm(OrdinancaDbContext context)
        {
            InitializeComponent();
            this.context = context;
            this.FormClosed += CurrentForm_FormClosed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Administrata admin = context.Administrata.Where(a => a.Email == email.Text).FirstOrDefault();

            if (string.IsNullOrEmpty(email.Text)
                || string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("Mbushini te gjitha te dhenat ose kontrollo passwordin!");
            }
            else if (admin == null)
            {
                MessageBox.Show("Administratori me kete email nuk egziston!");
            }
            else
            {
                if (HashPassword.Compare(password.Text, admin.Password))
                {
                    AdminDashboard adminDashboard = 
                        new AdminDashboard(CreateDbConnection.makeMySqlConnection(), admin);
                    adminDashboard.Show();
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
            IdentifikohuSiDoktorForm identifikohuForm =
                new IdentifikohuSiDoktorForm(CreateDbConnection.makeMySqlConnection());
            identifikohuForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm =
                new RegisterForm(CreateDbConnection.makeMySqlConnection());
            registerForm.Show();
            this.Hide();
        }

        private void Identifikohu_Form_Load(object sender, EventArgs e)
        {

        }

        private void CurrentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Exit the application when the current form is closed
        }
    }
}
