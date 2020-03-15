using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace test_qr_code.Models
{
    public class Market
    {
        [Key]
        public int MarketID { get; set; }
        public string Naziv { get; set; }
    }
}
