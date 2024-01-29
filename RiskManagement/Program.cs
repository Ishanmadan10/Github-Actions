using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskManagement2
{
   class Program
    {
        static void Main()
        {
            // Setup dependencies
            var tdsXMLDataReader = new TDSXMLDataReader();
            tdsXMLDataReader.setFilePath("TDSFilePath.xml");

            var rdsXMLDataReader = new RDSXMLDataReader();
            rdsXMLDataReader.setFilePath("RDSFilePath.xml");

            var dataMerger = new RDSTDSDataMerger();
            var riskCalculator = new CounterpartyRiskCalculator();
            var reportGenerator = new ExcelRiskReportGenerator();
            reportGenerator.setTargetFilePath("ReportFilePath.xlsx");

            // Instantiate FinanceRiskController
            var financeRiskController = new FinanceRiskController(
                tdsXMLDataReader,
                rdsXMLDataReader,
                dataMerger,
                riskCalculator,
                reportGenerator
            );

            // Run risk analysis
            financeRiskController.RunRiskAnalysis();
        }
    }
    
}
