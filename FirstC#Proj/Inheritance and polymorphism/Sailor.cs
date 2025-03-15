using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class Sailor : Human
    {
        private string _rank;

        public Sailor(string rank, int age, string name) : base(age, name)
        {
            base.Name = name;
            base.Age = age;
            _rank = rank;
        }

        public string Rank
        {
            get { return _rank; }
            set { _rank = value; }
        }

        public void DoWork()
        {
            base.ToString();
            Console.WriteLine($"Sailor {Name} is work");
        }
    }
}
