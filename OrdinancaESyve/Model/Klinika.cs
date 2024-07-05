using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OrdinancaESyve.Model
{
    public class Klinika
    {
        [Key]
        public int KlinikaID{ get; set; }
        public string Lokacioni{ get; set; }

        public Klinika() { }

        public Klinika(string Lokacioni) {
            this.Lokacioni = Lokacioni;
        }
    }
}
