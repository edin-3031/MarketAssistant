using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarketAssistant.Models
{
    public class Market
    {
        [Key]
        public int MarketID { get; set; }

        public string Naziv { get; set; }
        public string Adresa { get; set; }

        public Administrator Administrator { get; set; }
        [ForeignKey("Administrator")]
        public int? Administrator_FK { get; set; }
    }
}
