using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskManagement2
{
    public class FinanceRiskController
    {
        private iTDSXMLDataReader tdsXMLDataReader;
        private iRDSXMLDataReader rdsXMLDataReader;
        private iDataMerger<RDSDataModel, TDSDataModel, MergedData> dataMerger;
        private RiskCalculator riskCalculator;
        private ReportGenerator reportGenerator;

        public FinanceRiskController(
            iTDSXMLDataReader tdsXMLDataReader,
            iRDSXMLDataReader rdsXMLDataReader,
            iDataMerger<RDSDataModel, TDSDataModel, MergedData> dataMerger,
            RiskCalculator riskCalculator,
            ReportGenerator reportGenerator)
        {
            this.tdsXMLDataReader = tdsXMLDataReader;
            this.rdsXMLDataReader = rdsXMLDataReader;
            this.dataMerger = dataMerger;
            this.riskCalculator = riskCalculator;
            this.reportGenerator = reportGenerator;
        }

        public void RunRiskAnalysis()
        {
            var tdsData = tdsXMLDataReader.getTDSDataList();
            var rdsData = rdsXMLDataReader.getRDSDataList();

            var mergedData = dataMerger.mergeData(rdsData, tdsData);
            var riskResult = riskCalculator.calculate(new List<RiskInputDataModel> { new RiskInputDataModel() });

            reportGenerator.generateReport(riskResult);
            reportGenerator.save();
        }
    }
}
