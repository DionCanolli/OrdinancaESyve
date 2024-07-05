using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdinancaESyve.Model
{
    internal class RradhaDTO
    {
        public Doktori Doktori { get; set; }
        public Pacienti Pacienti { get; set; }
        public DateTime Takimi { get; set; }
        public string EmriDoktorit { get; set; }
        public string EmriPacientit { get; set; }
        public string KohaTakimitString { get; set; }
    }
}
