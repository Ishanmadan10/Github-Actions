using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RiskManagement2
{
    public class RDSTDSDataMerger : iDataMerger<RDSDataModel, TDSDataModel, MergedData>

    {
        public List<MergedData> mergeData(List<RDSDataModel> array1, List<TDSDataModel> array2)
        {
            
                List<MergedData> mergedData = new List<MergedData>();

                foreach (var item1 in array1)
                {
                MergedData mergedItem = Activator.CreateInstance<MergedData>();
                    Type type1 = typeof(RDSDataModel);
                    Type type2 = typeof(TDSDataModel);

                    foreach (PropertyInfo prop in type1.GetProperties())
                    {
                        PropertyInfo prop2 = type2.GetProperty(prop.Name);

                        if (prop2 != null && prop.CanWrite)
                        {
                            prop.SetValue(mergedItem, prop2.GetValue(item1));
                        }
                        else if (prop.CanWrite)
                        {
                            prop.SetValue(mergedItem, prop.GetValue(item1));
                        }
                    }

                    mergedData.Add(mergedItem);
                }

                return mergedData;
           
        }
    }

}
