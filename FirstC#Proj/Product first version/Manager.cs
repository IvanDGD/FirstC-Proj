﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    class Manager : Worker
    {
        public Manager(string name) : base(name) { }

        public override void Print()
        {
            Console.WriteLine($"Manager: {Name}\nOversees operations, manages teams, and ensures efficiency.");
        }
    }
}
