using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace FirstC_Proj
{
    public class Player
    {
        public string Name { get; set; }

        private int score;
        public int Score
        {
            get { return score; }
            set
            {
                score = value;
                CheckLevelUp();
            }
        }
        public int Level { get; private set; }

        public Player(string name)
        {
            Name = name;
            Level = 1;
        }

        private void CheckLevelUp()
        {
            if (score >= 10)
            {
                Level++;
                Console.WriteLine($"{Name} reached the level {Level}!");
                score = 0;
            }
        }
    }
}
