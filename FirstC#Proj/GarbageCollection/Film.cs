using System;

namespace FirstC_Proj.GarbageCollection
{
    internal class Film : IDisposable
    {
        private string _filmName { get; set; }
        private string _filmStudioName { get; set; }
        private string _genre { get; set; }
        private float _duration { get; set; }
        private DateTime _yearOfRelease { get; set; }

        public Film(string filmName, string genre, string filmStudioName, float duration, DateTime yearOfRelease)
        {
            _filmName = filmName;
            _filmStudioName = filmStudioName;
            _genre = genre;
            _duration = duration;
            _yearOfRelease = yearOfRelease;
        }

        public void Show()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Name: {_filmName}\n" +
                   $"Studio name: {_filmStudioName}\n" +
                   $"Genre: {_genre}\n" +
                   $"Duration (h,m): {_duration}\n" +
                   $"Year of film release: {_yearOfRelease:yyyy-MM-dd}\n";
        }

        ~Film()
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
                    Console.WriteLine($"Disposing film");
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