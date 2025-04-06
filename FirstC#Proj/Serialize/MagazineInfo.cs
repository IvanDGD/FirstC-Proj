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
            return "Назва: " + Title + "\n" +
                   "Видавництво: " + Publisher + "\n" +
                   "Дата випуску: " + ReleaseDate.ToShortDateString() + "\n" +
                   "Кількість сторінок: " + PageCount;
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
            string pagesInput = Console.ReadLine();
            int pageCount = Convert.ToInt32(pagesInput);

            return new MagazineInfo(title, publisher, releaseDate, pageCount);
        }

        public static string SerializeMagazine(MagazineInfo magazine)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
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
