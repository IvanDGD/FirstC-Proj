using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FirstC_Proj.IInterfaces.ResearcherDemo
{
    internal class Phycician : IResearcher
    {
        public string Subject { get; set; }

        public void Invent()
        {
            Console.WriteLine("Винайшли число пі");
        }

        public void Investigate()
        {
            Console.WriteLine("Досліджуєму єлектро єнергію");
        }
    }
}
