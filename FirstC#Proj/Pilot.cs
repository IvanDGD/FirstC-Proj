using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class Pilot : Human
    {

        private string _numberOfFlights;

        public Pilot(string numberOfFlights, int age, string name) : base(age, name)
        {
            base.Name = name;
            base.Age = age;
            _numberOfFlights = numberOfFlights;
        }

        public string Rank
        {
            get { return _numberOfFlights; }
            set { _numberOfFlights = value; }
        }

        public void DoWork()
        {
            base.ToString();
            Console.WriteLine($"Pilot {Name} in flight");
        }

    }
}
