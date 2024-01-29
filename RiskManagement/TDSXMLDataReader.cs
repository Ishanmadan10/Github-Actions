using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskManagement2
{
    public class TDSXMLDataReader : iTDSXMLDataReader
    {
        private string filePath;

        public List <TDSDataModel> getTDSDataList()
        {
            // Implementation details for reading TDS data from XML
            return new List<TDSDataModel> ();
        }

        public void setFilePath(string filePath)
        {
            this.filePath = filePath;
        }
    }
}
