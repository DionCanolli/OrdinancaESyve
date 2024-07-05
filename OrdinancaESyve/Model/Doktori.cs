using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdinancaESyve.Model
{
    public class Doktori
    {
        [Key]
        public int DoktorID { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string Email { get; set; }
        public int Mosha { get; set; }

        [ForeignKey("KlinikaID")]
        public int KlinikaID{ get; set; }
        public string Password { get; set; }
        

        public Doktori(string Emri, string Mbiemri, string Email, int Mosha, int KlinikaID,
            string Password)
        {
            this.Emri = Emri;
            this.Mbiemri = Mbiemri;
            this.Email = Email;
            this.Mosha = Mosha;
            this.KlinikaID = KlinikaID;
            this.Password = Password;
        }

        public Doktori() { }
    }
}
