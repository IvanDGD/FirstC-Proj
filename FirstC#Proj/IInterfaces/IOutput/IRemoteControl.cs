using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.IInterfaces.IOutput
{
    internal interface IRemoteControl
    {
        void TurnOn();
        void TurnOff();
        void SetChannel(int channel);

    }
}
