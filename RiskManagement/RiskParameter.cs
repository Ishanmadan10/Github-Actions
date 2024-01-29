using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskManagement2
{
    public class RiskParameter
    {
        public decimal Threshold { get; set; }
        public int MaximumAllowedExposure { get; set; }
        // Add other relevant properties based on your risk calculation parameters

        public override string ToString()
        {
            return $"Threshold: {Threshold}, Maximum Allowed Exposure: {MaximumAllowedExposure}";
        }
    }
}
