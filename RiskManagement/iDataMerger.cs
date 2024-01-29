using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskManagement2
{
    public interface iDataMerger<T1, T2, T>
    {
       List <T> mergeData(List<T1> array1, List<T2> array2);
    }
}
