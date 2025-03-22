using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.Delegate
{
    internal class Counter
    {
        public delegate int StringDelegate(string input);

        public static int CountVowels(string input)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";
            foreach (char c in input)
            {
                if (vowels.Contains(c))
                    count++;
            }
            return count;
        }

        public static int CountConsonants(string input)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";
            foreach (char c in input)
            {
                if (char.IsLetter(c) && !vowels.Contains(c))
                    count++;
            }
            return count;
        }

        public static int GetStringLength(string input)
        {
            return input.Length;
        }
    }
}
