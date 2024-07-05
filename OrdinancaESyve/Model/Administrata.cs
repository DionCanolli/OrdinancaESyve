using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdinancaESyve.Model
{
    public class Administrata
    {
        [Key]
        public int AdministratorID { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Administrata(string Emri, string Mbiemri, string Email, string Password)
        {
            this.Emri = Emri;
            this.Mbiemri = Mbiemri;
            this.Email = Email;
            this.Password = Password;
        }

        public Administrata() { }

        public string ToStringg()
        {
            return this.Emri + " " + this.Mbiemri + " " + this.Email + " " + " " + this.Password;
        }
    }
}
