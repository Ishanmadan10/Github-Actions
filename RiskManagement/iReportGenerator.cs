using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskManagement2
{
    public interface ReportGenerator
    {
        void generateReport(List<RiskResult> riskResults);
        void save();
    }
}
