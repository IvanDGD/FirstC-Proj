using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.IInterfaces.ResearcherDemo
{
    internal class Matematician : IResearcher
    {
        string IResearcher.Subject { get; set ; }

        public void Invent()
        {
            Console.WriteLine("Винайшли уявне число i");
        }

        public void Investigate()
        {
            Console.WriteLine("Досліджуєму квадратичні рівняння...");
        }
    }
}
