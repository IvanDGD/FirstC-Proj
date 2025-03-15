using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.DoorExample
{
    internal class Alarm
    {
        private string _code = "1234";

        public void OnDoorOpen()
        {
            Console.WriteLine("Enter code: ");
            string code = Console.ReadLine();

            if (code == _code)
            {

            }
            else {
                Console.WriteLine("Incorrect code, we call the SBU");
            }

        }
    }
}
