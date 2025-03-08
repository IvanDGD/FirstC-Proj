using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class BankruptException : ApplicationException
    {
        public BankruptException(string message) : base(message) { }
    }
}
