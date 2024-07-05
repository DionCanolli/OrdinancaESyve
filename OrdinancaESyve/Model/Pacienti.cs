using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdinancaESyve.Model
{
    public class Pacienti
    {
        [Key]
        public int PacientID { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string NrTel { get; set; }
        public int Mosha { get; set; }

        public Pacienti(string Emri, string Mbiemri, string NrTel, int Mosha)
        {
            this.Emri = Emri;
            this.Mbiemri = Mbiemri;
            this.NrTel = NrTel;
            this.Mosha = Mosha;
        }

        public Pacienti() { }

        public string ToStringg()
        {
            return this.Emri + " " + this.Mbiemri + " " + this.NrTel + " " + " " + this.Mosha;
        }
    }
}
