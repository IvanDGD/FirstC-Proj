using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.GenericCollections
{
    internal class Apartment
    {
        public string Number { get; set; }
        public List<string> Residents { get; set; }

        public Apartment(string number)
        {
            Number = number;
            Residents = new List<string>();
        }

        public void AddResident(string name)
        {
            Residents.Add(name);
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (var resident in Residents)
            {
                yield return resident;
            }
        }
    }
}
