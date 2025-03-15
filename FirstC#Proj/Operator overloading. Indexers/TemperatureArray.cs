using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class TemperatureArray
    {
        private double[] temperatures = new double[7];

        public double this[int day]
        {
            get
            {
                if (day < 0 || day > 6)
                    throw new ArgumentOutOfRangeException("Day index must be between 0 and 6.");
                return temperatures[day];
            }
            set
            {
                if (day < 0 || day > 6)
                    throw new ArgumentOutOfRangeException("Day index must be between 0 and 6.");
                temperatures[day] = value;
            }
        }

        public void ShowTemperatures()
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.WriteLine($"{days[i]}: {temperatures[i]}°C");
            }
        }
    }
}
