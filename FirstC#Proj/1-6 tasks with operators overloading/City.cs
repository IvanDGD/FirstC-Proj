using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class City
    {

        public int Population { get; set; }

        public City() {}

        public City(int populationo)
        {
            Population = populationo;
        }
        public override bool Equals(object? obj)
        {
            return obj != null && this.ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public static int operator +(City popul, int value)
        {
            return popul.Population + value;
        }

        public static int operator -(City popul, int value)
        {
            return popul.Population - value;
        }

        public static bool operator ==(City popul1, City popul2)
        {
            return popul1.Equals(popul2);
        }
        public static bool operator !=(City emp1, City emp2)
        {
            return !(emp1 == emp2);
        }
        public static bool operator >(City popul1, City popul2)
        {
            if (popul1 is null || popul2 is null) return false;
            return popul1.Population > popul2.Population;
        }

        public static bool operator <(City popul1, City popul2)
        {
            if (popul1 is null || popul2 is null) return false;
            return popul1.Population < popul2.Population;
        }

        public override string ToString()
        {
            return $"Population: {Population}";
        }

    }
}
