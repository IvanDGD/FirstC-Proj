using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class Human
    {

        private int _age;
        private string _name;

        public string Name
        {
            get { return _name; } 
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Human(int age, string name)
        {
            _age = age;
            _name = name;
        }

        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {Name}");
            sb.Append($"Age: {Age}");
            return sb.ToString();
        }

    }
}
