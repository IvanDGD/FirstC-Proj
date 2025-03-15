using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.IInterfaces.IOutput
{
    internal class TV : IRemoteControl
    {
        private bool IsOn { set; get; }
        private int Channel { set; get; }

        public TV()
        {
            Channel = 0;
            IsOn = false;

        }
        public void SetChannel(int channel)
        {
            if (IsOn)
            { 
                Console.WriteLine($"Channel {Channel} has been changed to channel {channel}");
                Channel = channel;
            }
            else
            {
                Console.WriteLine("The TV is turn off");
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
                Console.WriteLine("The TV was turned off");
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
                Console.WriteLine("The TV was turned on");
            }
        }
    }
}
