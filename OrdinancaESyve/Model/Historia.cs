using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdinancaESyve.Model
{
    public class Historia
    {
        [Key]
        public int HistoriaID { get; set; }

        [ForeignKey("DoktorID")]
        public int DoktorID { get; set; }

        [ForeignKey("PacientID")]
        public int PacientID { get; set; }
        public DateTime KohaTerminit { get; set; }
    }
}
