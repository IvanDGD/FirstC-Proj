using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    public class Player
    {
        public static int countOfPlayers = 0;
        public const float P1 = 3.14f;
        public readonly int id = 0;

        private float speed = 10f;
        protected int health = 100;
        internal protected string name = "Player1";

        internal protected void Print()
        {
            Console.WriteLine($"{name} {health} {speed}");
        }

        static Player()
        {
            countOfPlayers = 0;
        }

        public Player() : this(1, 10f, 150, "Player1")
        { }

        public Player(int id, float speed, int health, string name)
        {
            this.id = id;
            this.speed = speed;
            this.health = health;
            this.name = name;
        }

        public Player(int id)
        {
            this.id = id;
        }
    }
}
