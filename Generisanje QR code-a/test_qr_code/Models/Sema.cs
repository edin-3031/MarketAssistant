using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace test_qr_code.Models
{
    public class Sema
    {
        [Key]
        public int SemaID { get; set; }
        public string Sadrzaj { get; set; }
        public Market Market { get; set; }
        [ForeignKey("Market")]
        public int Market_FK { get; set; }
    }
}
