﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.GenericCollections
{
    internal class Patient
    {
        public string Name { get; set; }
        public int Severity { get; set; } 

        public Patient(string name, int severity)
        {
            Name = name;
            Severity = severity;
        }

        public override string ToString()
        {
            return $"{Name} (Severity: {Severity})";
        }
    }
}
