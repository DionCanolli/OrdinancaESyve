using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class RegjistrohuSiDoktorForm : Form
    {
        private readonly OrdinancaDbContext context;

        public RegjistrohuSiDoktorForm(OrdinancaDbContext context)
        {
            InitializeComponent();
            this.context = context;
            klinika_prishtine.Checked = true;
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

        private void regjistroDoktorButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emriDoktoritTextBox.Text)
                || string.IsNullOrEmpty(mbiemriDoktoritTextBox.Text)
                || string.IsNullOrEmpty(emailDoktoritTextBox.Text)
                || string.IsNullOrEmpty(passwordDoktoritTextBox.Text)
                || string.IsNullOrEmpty(konfirmoDoktoritPasswordinTextBox.Text)
                || passwordDoktoritTextBox.Text != konfirmoDoktoritPasswordinTextBox.Text
                || !IsValidEmail(emailDoktoritTextBox.Text))
            {
                MessageBox.Show("Gabim Kredencialet!");
            }
            else if(passwordDoktoritTextBox.Text.Length <= 5)
            {
                MessageBox.Show("Passwordi le te jete me shume se 5 karaktere");
            }
            else if (context.Doktori.Where(s => s.Email == emailDoktoritTextBox.Text).FirstOrDefault() != null)
            {
                MessageBox.Show("Doktori me kete email egziston!");
            }
            else
            {
                string hashedPassword = HashPassword.Encrypt(passwordDoktoritTextBox.Text);

                Klinika klinika = null;

                if (klinika_prishtine.Checked)
                {
                    klinika = context.Klinika.Where(k => k.Lokacioni == klinika_prishtine.Text).First();
                }
                else
                {
                    klinika = context.Klinika.Where(k => k.Lokacioni == klinika_prizren.Text).First();
                }

                Doktori doktori = new Doktori();
                doktori.Emri = emriDoktoritTextBox.Text;
                doktori.Mbiemri = mbiemriDoktoritTextBox.Text;
                doktori.Email = emailDoktoritTextBox.Text;
                doktori.Password = hashedPassword;
                doktori.Mosha = Convert.ToInt32(moshaDoktoritNumericBox.Value);
                doktori.KlinikaID = klinika.KlinikaID;

                context.AddDoctor(doktori);

                IdentifikohuSiDoktorForm identifikohuForm =
                    new IdentifikohuSiDoktorForm(CreateDbConnection.makeMySqlConnection());
                this.Close();
                identifikohuForm.Show();
            }
        }

        private void navigoTeRegjistroSiPacientButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm =
                new RegisterForm(CreateDbConnection.makeMySqlConnection());
            this.Close();
            registerForm.Show();
        }

        private void klinika_prishtine_CheckedChanged(object sender, EventArgs e)
        {
            if (klinika_prishtine.Checked)
            {
                klinika_prizren.Checked = false;
            }
        }

        private void klinika_prizren_CheckedChanged(object sender, EventArgs e)
        {
            if (klinika_prizren.Checked)
            {
                klinika_prishtine.Checked = false;
            }
        }

        private void keniLlogariButton_Click(object sender, EventArgs e)
        {
            IdentifikohuSiDoktorForm identifikohuSiDoktorForm =
                new IdentifikohuSiDoktorForm(CreateDbConnection.makeMySqlConnection());
            this.Close();
            identifikohuSiDoktorForm.Show();
        }

        private void navigoTeRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm =
                new RegisterForm(CreateDbConnection.makeMySqlConnection());
            this.Close();
            registerForm.Show();
        }

        private void RegjistrohuSiDoktorForm_Load(object sender, EventArgs e)
        {

        }

        private void CurrentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Exit the application when the current form is closed
        }


    }
}
