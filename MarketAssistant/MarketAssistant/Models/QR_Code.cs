using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarketAssistant.Models
{
    public class QR_Code
    {
        [Key]
        public int QR_CodeID { get; set; }

        public byte[] Slika { get; set; }

        public Market Market { get; set; }
        [ForeignKey("Market")]
        public int? Market_FK { get; set; }
    }
}
