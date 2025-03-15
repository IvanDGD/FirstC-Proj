using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.DoorExample
{
    internal class Door
    {
        public delegate void DoorDelegate();
        public event DoorDelegate OnOpenDoor;
        public bool IsOpen { get; private set; }

        public void OpenDoor()
        {
            OnOpenDoor.Invoke();
        }
    }
}
