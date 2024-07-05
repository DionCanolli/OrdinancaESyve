using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdinancaESyve.Model
{
    public class Raporti
    {
        [Key]
        public int RaportID { get; set; }
        public string EmriDiagnozes { get; set; }
        public string PershkrimiDiagnozes { get; set; }

        [ForeignKey("PacientID")]
        public int PacientID { get; set; }

        [ForeignKey("DoktorID")]
        public int DoktorID { get; set; }
        public DateTime KohaShkrimitRaportit { get; set; }

        public Raporti() { }

        public Raporti(string EmriDiagnozes, string PershkrimiDiagnozes, int PacientID)
        {
            this.EmriDiagnozes = EmriDiagnozes;
            this.PershkrimiDiagnozes = PershkrimiDiagnozes;
            this.PacientID = PacientID;
        }

        public string ToString()
        {
            return RaportID + " " + EmriDiagnozes + " " + PacientID + " " + DoktorID;
        }
    }
}
