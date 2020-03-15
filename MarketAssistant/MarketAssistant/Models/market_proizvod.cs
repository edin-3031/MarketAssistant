
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarketAssistant.Models
{
    public class market_proizvod
    {
        [Key]
        public int mpID { get; set; }

        public int? NaStanju { get; set; }

        public DateTime? DatumDobavljanja { get; set; }

        public bool? Rasprodano { get; set; }

        public Market Market { get; set; }
        [ForeignKey("Market")]
        public int? Market_FK { get; set; }

        public Proizvod Proizvod { get; set; }
        [ForeignKey("Proizvod")]
        public int? Proizvod_FK { get; set; }
    }
}
