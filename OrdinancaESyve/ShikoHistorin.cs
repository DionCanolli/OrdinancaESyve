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
using System.Windows.Forms.VisualStyles;

namespace OrdinancaESyve
{
    public partial class ShikoHistorin : Form
    {
        private Administrata administrata;
        private OrdinancaDbContext context;
        public ShikoHistorin(OrdinancaDbContext context, Administrata administrata)
        {
            this.administrata = administrata;
            this.context = context;
            InitializeComponent();
            this.FormClosed += CurrentForm_FormClosed;
        }

        private void ShikoHistorin_Load(object sender, EventArgs e)
        {
            try
            {
                List<Historia> historit = this.context.Historia.ToList();

                foreach(Historia hist in historit)
                {
                    Pacienti p = this.context.Pacienti.Where(pac => pac.PacientID == hist.PacientID)
                        .FirstOrDefault();
                    Doktori d = this.context.Doktori.Where(dok => dok.DoktorID == hist.DoktorID)
                        .FirstOrDefault();

                    if (p != null && d != null)
                    {
                        dataGridView1.Rows.Add(p.Emri, p.Mbiemri, p.NrTel, p.Mosha, d.Emri, d.Mbiemri,
                            d.Email, hist.KohaTerminit);
                    }
                }
            }catch(Exception ex) {
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void kthehuPas_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard(CreateDbConnection.makeMySqlConnection(),
                administrata);
            adminDashboard.Show();
            this.Hide();
        }

        private void CurrentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Exit the application when the current form is closed
        }
    }
}
