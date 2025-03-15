using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    abstract class Worker
    {
        protected string Name;

        public Worker(string name)
        {
            Name = name;
        }

        public abstract void Print();
    }
}
