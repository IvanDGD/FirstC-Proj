using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.IInterfaces.ResearcherDemo
{
    internal interface IResearcher
    {
        string Subject { get; set; }
        void Investigate();
        void Invent();
    }
}
