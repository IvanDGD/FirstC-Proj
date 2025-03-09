using System;
using FirstC_Proj.GarbageCollection;

namespace FirstC_Proj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Film film = new Film("Star Wars", "A New Hope", "Lucasfilm", 2.1f, new DateTime(1977, 5, 25));
            film.Show();
            film = null;

            Console.WriteLine("Garbage collection");
            GC.Collect();

            Console.WriteLine("End Task 1.\n");
            #endregion

            #region Task2
            string[] actors = { "Keanu Reeves", "Laurence Fishburne", "Carrie Anne Moss" };
            using (Play play = new Play("Test", "Test", "Test", 3.15f, actors))
            {
                play.Show();
            }
            Play play2 = new Play("Test", "Test", "Test", 2.28f, new string[] { "Leonardo DiCaprio", "Joseph Gordon Levitt" });
            try
            {
                play2.Show();
            }
            finally
            {
                play2.Dispose();
            }

            Console.WriteLine("End Task 2.\n");
            #endregion
        }
    }
}