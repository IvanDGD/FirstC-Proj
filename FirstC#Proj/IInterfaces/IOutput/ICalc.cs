using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.IInterfaces.IOutput
{
    internal interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }
}
