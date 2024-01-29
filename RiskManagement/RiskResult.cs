using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskManagement2
{
    public class RiskResult
    {
        public decimal TotalRisk { get; set; }
        public decimal CounterpartyRisk { get; set; }
        // Add other relevant properties based on your risk calculation

        public override string ToString()
        {
            return $"Total Risk: {TotalRisk}, Counterparty Risk: {CounterpartyRisk}";
        }
    }
}
