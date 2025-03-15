using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.IInterfaces.IOutput
{
    internal class Radio : IRemoteControl
    {
        private bool IsOn { set; get; }
        private int _Channel { set; get; }

        public Radio()
        {
            _Channel = 0;
            IsOn = false;

        }
        public void SetChannel(int channel)
        {
            if (IsOn)
            {
                
                Console.WriteLine($"Channel {_Channel} has been changed to channel {channel}");
                _Channel = channel;
            }
            else
            {
                Console.WriteLine("The radio is turn off");
            }
        }

        public void TurnOff()
        {
            if (IsOn)
            {
                IsOn = false;
            }
            else
            {
                Console.WriteLine("The radio was turned off");
            }
        }

        public void TurnOn()
        {
            if (!IsOn)
            {
                IsOn = true;
            }
            else
            {
                Console.WriteLine("The radio was turned on");
            }
        }
    }
}
