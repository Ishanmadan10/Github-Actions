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
            public List<MergedData> MergeData(List<RDSDataModel> array1, List<TDSDataModel> array2)
            {
                return array1.Select(item1 => MergeItem(item1)).ToList();
            }

            private MergedData MergeItem(RDSDataModel item1)
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

                return mergedItem;
            }
        }
    }



