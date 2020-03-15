using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarketAssistant.Models
{
    public class Proizvod
    {
        [Key]
        public int ProizvodID { get; set; }

        public string Naziv { get; set; }
        public DateTime? DatumProizvodnje { get; set; }
        public DateTime? TrajeDo { get; set; }
        public string Sastav { get; set; }
        public string Opis { get; set; }
        public byte[] Slika { get; set; }

        public Brend Brend { get; set; }
        [ForeignKey("Brend")]
        public int? Brend_FK { get; set; }

        public Vrsta Vrsta { get; set; }
        [ForeignKey("Vrsta")]
        public int? Vrsta_FK { get; set; }

        public Administrator Administrator { get; set; }
        [ForeignKey("Administrator")]
        public int? Administrator_FK { get; set; }
    }
}
