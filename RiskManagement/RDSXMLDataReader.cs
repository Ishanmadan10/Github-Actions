using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskManagement2
{
    public class RDSXMLDataReader : iRDSXMLDataReader
    {
        private string filePath;

        public List<RDSDataModel> getRDSDataList()
        {
            // Implementation details for reading RDS data from XML
            return new List<RDSDataModel>();
        }

        public void setFilePath(string filePath)
        {
            this.filePath = filePath;
        }
    }

}
