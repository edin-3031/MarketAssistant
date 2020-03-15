using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketAssistant.VM
{
    public class MarketSemaVM
    {
        public int marketId { get; set; }
        public string naziv { get; set; }
    }

    public class MarketSemaVM_lista
    {
        public List<MarketSemaVM> lista { get; set; }
    }
}
