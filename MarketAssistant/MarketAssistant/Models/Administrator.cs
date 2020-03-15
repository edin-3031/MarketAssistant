using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarketAssistant.Models
{
    public class Administrator
    {
        [Key]
        public int AdministratorID { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public int? Staz { get; set; }
        public bool? Spol { get; set; }
        public byte[] Slika { get; set; }
    }
}
