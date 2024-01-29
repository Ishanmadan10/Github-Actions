using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskManagement2
{
    public class ExcelRiskReportGenerator : ReportGenerator
    {
        private string targetFilePath;

        public void setTargetFilePath(string path)
        {
            targetFilePath = path;
        }

        public void generateReport(List<RiskResult> riskResults)
        {
            // Implementation details for generating Excel report
        }

        public void save()
        {
            // Implementation details for saving Excel report
        }
    }
}
