using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskManagement2
{
    public class CounterpartyRiskCalculator : RiskCalculator
    {
        private RiskParameter riskParameter;

        public void configureRiskParameter(RiskParameter riskParameter)
        {
            this.riskParameter = riskParameter;
        }

        public List<RiskResult>calculate(List<RiskInputDataModel> riskInputDataModels)
        {
            // Implementation details for risk calculation

            return new List<RiskResult>();
        }
    }
}
