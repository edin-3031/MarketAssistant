using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarketAssistant.Models
{
    public class Brend
    {
        [Key]
        public int BrendID { get; set; }

        public string Naziv { get; set; }
    }
}
