using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskManagement2
{
    public interface RiskCalculator
    {
        List<RiskResult> calculate(List<RiskInputDataModel> riskInputDataModels);
    }
}
