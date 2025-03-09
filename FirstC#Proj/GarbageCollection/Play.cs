using System;

namespace FirstC_Proj.GarbageCollection
{
    internal class Play : IDisposable
    {
        private string _performanceName { get; set; }
        private string _theaterName { get; set; }
        private string _genre { get; set; }
        private float _duration { get; set; }
        private string[] _actorsList { get; set; }

        public Play(string performanceName, string genre, string theaterName, float duration, string[] actorsList)
        {
            _performanceName = performanceName;
            _theaterName = theaterName;
            _genre = genre;
            _duration = duration;
            _actorsList = actorsList;
        }
        public void Show()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Name: {_performanceName}\n" +
                   $"Theater name: {_theaterName}\n" +
                   $"Genre: {_genre}\n" +
                   $"Duration (h,m): {_duration}\n" +
                   $"Actors: {string.Join(", ", _actorsList)}\n";
        }

        ~Play()
        {
            Console.WriteLine($"Finalizer");
            Dispose(false);
        }
        private bool _disposed = false;

        protected void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (!disposing)
                {
                    Console.WriteLine($"Disposing play");
                    _disposed = true;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}