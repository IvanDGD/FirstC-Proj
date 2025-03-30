using System;
using System.IO;
using System.Text.Json;

namespace FirstC_Proj.Serialize
{
    internal class MusicalAlbum
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int ReleaseYear { get; set; }
        public List<Song> Songs { get; set; }
        public double Duration { get; set; }
        public string RecordLabel { get; set; }

        public MusicalAlbum()
        {
            Songs = new List<Song>();
        }
        public MusicalAlbum(string title, string artist, int releaseYear, double duration, string recordLabel, List<Song> songs)
        {
            Title = title;
            Artist = artist;
            ReleaseYear = releaseYear;
            Songs = songs;
            Duration = duration;
            RecordLabel = recordLabel;
        }
        public void InputAlbum()
        {
            Console.Write("Enter album title: ");
            Title = Console.ReadLine();

            Console.Write("Enter artist name: ");
            Artist = Console.ReadLine();

            Console.Write("Enter release year: ");
            ReleaseYear = int.Parse(Console.ReadLine());

            Console.Write("Enter record label: ");
            RecordLabel = Console.ReadLine();

            Console.Write("How many songs are in the album? ");
            int songCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < songCount; i++)
            {
                Console.WriteLine($"Entering details for song {i + 1}:");
                Song song = InputSong();
                Songs.Add(song);
            }
        }
        private Song InputSong()
        {
            Console.Write("Enter song title: ");
            string title = Console.ReadLine();

            Console.Write("Enter song duration (in minutes): ");
            double duration = double.Parse(Console.ReadLine());

            Console.Write("Enter song genre: ");
            string genre = Console.ReadLine();

            return new Song(title, duration, genre);
        }
        public void DisplayAlbum()
        {
            Console.WriteLine("Album Information:");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Artist: {Artist}");
            Console.WriteLine($"Release Year: {ReleaseYear}");
            Console.WriteLine($"Record Label: {RecordLabel}");
            Console.WriteLine("Songs in the Album:");
            foreach (var song in Songs)
            {
                Console.WriteLine($" - Title: {song.Title}, Duration: {song.Duration} minutes, Genre: {song.Genre}");
            }
        }
        public string SerializeAlbum()
        {
            return JsonSerializer.Serialize(this);
        }
        public void SaveAlbumToFile()
        {
            string filePath = "album.json";
            string jsonString = SerializeAlbum();
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine($"Serialized album saved to {filePath}");
        }
        public MusicalAlbum LoadAlbumFromFile()
        {
            string filePath = "album.json";
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                MusicalAlbum album = JsonSerializer.Deserialize<MusicalAlbum>(jsonString);
                Console.WriteLine("Album loaded from file:");
                album.DisplayAlbum();
                return album;
            }
            else
            {
                Console.WriteLine("File not found.");
                return null;
            }
        }
    }
}
