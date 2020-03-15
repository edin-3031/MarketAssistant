using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarketAssistant.Models
{
    public class KorisnickiRacun
    {
        [Key]
        public int korisnickiRacunID { get; set; }

        public string KorisnickoIme { get; set; }
        public string SifraSalt { get; set; }
        public string SifraHash { get; set; }
        public bool? Aktivan { get; set; }

        public Administrator Administrator { get; set; }
        [ForeignKey("Administrator")]
        public int? Administrator_FK { get; set; }
    }
}
