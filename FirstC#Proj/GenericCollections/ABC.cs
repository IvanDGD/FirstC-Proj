using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class ABC : IEnumerable<char>
    {
        private char[] letters;

        public ABC()
        {
            letters = new char[26];
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = (char)('A' + i);
            }
        }

        public IEnumerator<char> GetEnumerator()
        {
            foreach (char letter in letters)
            {
                yield return letter;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
