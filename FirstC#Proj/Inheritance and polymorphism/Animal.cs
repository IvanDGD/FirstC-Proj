using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    abstract class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }

        protected Animal(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public abstract void DoSound();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Animal: {Name}");
            sb.AppendLine($"Description: {Description}");
            return sb.ToString();
        }
    }
}
