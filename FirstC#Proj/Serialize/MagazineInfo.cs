using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.Serialize
{
    internal class MagazineInfo
    {
        public string Title { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int PageCount { get; set; }
        public List<Article> Articles { get; set; } = new List<Article>();

        public MagazineInfo() { }

        public MagazineInfo(string title, string publisher, DateTime releaseDate, int pageCount)
        {
            Title = title;
            Publisher = publisher;
            ReleaseDate = releaseDate;
            PageCount = pageCount;
        }

        public override string ToString()
        {
            string result = "Назва: " + Title + "\n" +
                            "Видавництво: " + Publisher + "\n" +
                            "Дата випуску: " + ReleaseDate.ToShortDateString() + "\n" +
                            "Кількість сторінок: " + PageCount + "\n" +
                            "Статті:\n";

            for (int i = 0; i < Articles.Count; i++)
            {
                result += $"Стаття {i + 1}:\n{Articles[i]}\n";
            }

            return result;
        }

        public static MagazineInfo InputMagazine()
        {
            Console.Write("Назва журналу: ");
            string title = Console.ReadLine();

            Console.Write("Видавництво: ");
            string publisher = Console.ReadLine();

            Console.Write("Дата випуску (рррр-мм-дд): ");
            string dateInput = Console.ReadLine();
            DateTime releaseDate = DateTime.Parse(dateInput);

            Console.Write("Кількість сторінок: ");
            int pageCount = Convert.ToInt32(Console.ReadLine());

            MagazineInfo magazine = new MagazineInfo(title, publisher, releaseDate, pageCount);

            Console.Write("Скільки статей у журналі? ");
            int articleCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < articleCount; i++)
            {
                Console.WriteLine($"\nСтаття {i + 1}");

                Console.Write("  Назва статті: ");
                string articleTitle = Console.ReadLine();

                Console.Write("  Кількість символів: ");
                int charCount = Convert.ToInt32(Console.ReadLine());

                Console.Write("  Анонс статті: ");
                string preview = Console.ReadLine();

                magazine.Articles.Add(new Article(articleTitle, charCount, preview));
            }

            return magazine;
        }

        public static string SerializeMagazine(MagazineInfo magazine)
        {
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            return JsonSerializer.Serialize(magazine, options);
        }

        public static void SaveToFile(string json, string filename)
        {
            File.WriteAllText(filename, json);
        }

        public static string LoadFromFile(string filename)
        {
            return File.ReadAllText(filename);
        }

        public static MagazineInfo DeserializeMagazine(string json)
        {
            return JsonSerializer.Deserialize<MagazineInfo>(json);
        }
    }
}
