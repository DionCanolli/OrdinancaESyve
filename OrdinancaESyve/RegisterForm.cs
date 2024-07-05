using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Mail;
namespace OrdinancaESyve
{
    public partial class RegisterForm : Form
    {
        private readonly OrdinancaDbContext context;

        public RegisterForm(OrdinancaDbContext context)
        {
            InitializeComponent();
            this.context = context;
            this.FormClosed += CurrentForm_FormClosed;
        }
        public static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress address = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private async void regjistroButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emriTextBox.Text)
                || string.IsNullOrEmpty(mbiemriTextBox.Text)
                || string.IsNullOrEmpty(emailTextBox.Text)
                || string.IsNullOrEmpty(passwordTextBox.Text)
                || string.IsNullOrEmpty(konfirmoPasswordinTextBox.Text)
                || passwordTextBox.Text != konfirmoPasswordinTextBox.Text
                || !IsValidEmail(emailTextBox.Text))
            {
                MessageBox.Show("Mbushini te gjitha te dhenat ose kontrollo passwordin!");
            }
            if (passwordTextBox.Text.Length <= 5)
            {
                MessageBox.Show("Passwordi le te jete me shume se 5 karaktere");
            }
            else if (context.Administrata.Where(s => s.Email == emailTextBox.Text).FirstOrDefault() != null)
            {
                MessageBox.Show("Administratori me kete email egziston!");
            }
            else
            {
                string hashedPassword = HashPassword.Encrypt(passwordTextBox.Text);

                Administrata admin = new Administrata();
                admin.Emri = emriTextBox.Text;
                admin.Mbiemri = mbiemriTextBox.Text;
                admin.Email = emailTextBox.Text;
                admin.Password = hashedPassword;

                context.AddAdmin(admin);

                IdentifikohuForm identifikohuForm =
                    new IdentifikohuForm(CreateDbConnection.makeMySqlConnection());
                identifikohuForm.Show();
                this.Hide();
            }
        }

        private void keniLlogariButton_Click(object sender, EventArgs e)
        {
            IdentifikohuForm identifikohuForm =
                new IdentifikohuForm(CreateDbConnection.makeMySqlConnection());
            identifikohuForm.Show();
            this.Hide();
        }

        private void navigoTeRegjistroSiDoktorButton_Click(object sender, EventArgs e)
        {
            RegjistrohuSiDoktorForm regjistrohuSiDoktorForm =
                new RegjistrohuSiDoktorForm(CreateDbConnection.makeMySqlConnection());
            regjistrohuSiDoktorForm.Show();
            this.Hide();
        }

        private void Register_Form_Load(object sender, EventArgs e)
        {

        }

        private void CurrentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Exit the application when the current form is closed
        }
    }
}
