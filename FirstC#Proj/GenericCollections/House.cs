using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.GenericCollections
{
    internal class House : IEnumerable<Apartment>
    {
        private List<Apartment> apartments;

        public House()
        {
            apartments = new List<Apartment>();
        }

        public void AddApartment(Apartment apartment)
        {
            apartments.Add(apartment);
        }

        public IEnumerator<Apartment> GetEnumerator()
        {
            foreach (var apartment in apartments)
            {
                yield return apartment;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
