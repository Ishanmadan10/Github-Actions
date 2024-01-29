using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskManagement2
{
    public class TDSDataModel
    {
        public string TradeID { get; set; }
        public string Date { get; set; }
        public decimal Value { get; set; }
        public decimal CounterPartyIdRef { get; set; }
    }
}
