using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.IInterfaces.IOutput
{
    internal class PasswordValidator : IValidator
    {
        public bool Validate(string data)
        {
            return data.Length >= 8;
        }
    }
}
