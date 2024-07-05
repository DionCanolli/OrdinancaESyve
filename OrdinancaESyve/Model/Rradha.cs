using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrdinancaESyve.Model
{
    public class Rradha
    {
        [Key]
        public int TakimiID { get; set; }

        [ForeignKey("DoktorID")]
        public int DoktorID{ get; set; }

        [ForeignKey("PacientID")]
        public int PacientID { get; set; }
        public DateTime KohaTakimit{ get; set; }

        public Rradha() { }

        public Rradha(int DoktorID, int PacientID, DateTime KohaTakimit)
        {
            this.DoktorID = DoktorID;
            this.PacientID = PacientID;
            this.KohaTakimit = KohaTakimit;
        }

        public string ToStringg()
        {
            return DoktorID + " " + PacientID + " " + KohaTakimit;
        }
    }
}
