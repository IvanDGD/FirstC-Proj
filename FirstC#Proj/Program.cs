using System.Text.Json;
using FirstC_Proj.Serialize;

namespace FirstC_Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            #region Task1
            //Serialize.Fraction[] fractions = InputFractions();

            //string json = SerializeFractions(fractions);
            //SaveToFile(json, "fractions.json");

            //Console.WriteLine("Фракції збережено у файл 'fractions.json'.");

            //string loadedJson = LoadFromFile("fractions.json");
            //Serialize.Fraction[] loadedFractions = DeserializeFractions(loadedJson);

            //Console.WriteLine("Завантажено з файлу:");
            //for (int i = 0; i < loadedFractions.Length; i++)
            //{
            //    Console.WriteLine("Фракція " + (i + 1) + ": " + loadedFractions[i].ToString());
            //}
            #endregion
            #region Task2
            //MagazineInfo magazine = MagazineInfo.InputMagazine();

            //Console.WriteLine("\nВведено журнал:\n");
            //Console.WriteLine(magazine.ToString());

            //string json = MagazineInfo.SerializeMagazine(magazine);
            //MagazineInfo.SaveToFile(json, "magazine.json");
            //Console.WriteLine("\nЖурнал серіалізовано та збережено у 'magazine.json'.");

            //string loadedJson = MagazineInfo.LoadFromFile("magazine.json");
            //MagazineInfo loadedMagazine = MagazineInfo.DeserializeMagazine(loadedJson);

            //Console.WriteLine("\nЗавантажений з файлу журнал:\n");
            //Console.WriteLine(loadedMagazine.ToString());
            #endregion
            #region Task3
            //MagazineInfo magazine = MagazineInfo.InputMagazine();

            //Console.WriteLine("\nВведено журнал:\n");
            //Console.WriteLine(magazine.ToString());

            //string json = MagazineInfo.SerializeMagazine(magazine);
            //MagazineInfo.SaveToFile(json, "magazine.json");
            //Console.WriteLine("\nЖурнал серіалізовано та збережено у 'magazine.json'.");

            //string loadedJson = MagazineInfo.LoadFromFile("magazine.json");
            //MagazineInfo loadedMagazine = MagazineInfo.DeserializeMagazine(loadedJson);

            //Console.WriteLine("\nЗавантажений з файлу журнал:\n");
            //Console.WriteLine(loadedMagazine.ToString());
            #endregion
            #region Task4
            Console.Write("Скільки журналів ви хочете ввести? ");
            int count = Convert.ToInt32(Console.ReadLine());

            List<MagazineInfo> magazines = new List<MagazineInfo>();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\n--- Журнал #{i + 1} ---");
                MagazineInfo magazine = MagazineInfo.InputMagazine();
                magazines.Add(magazine);
            }

            Console.WriteLine("\nВведені журнали:\n");
            foreach (MagazineInfo magazine in magazines)
            {
                Console.WriteLine(magazine);
                Console.WriteLine("-------------------------------\n");
            }

            string json = SerializeMagazineArray(magazines);
            MagazineSaveToFile(json, "magazines.json");
            Console.WriteLine("Журнали серіалізовано та збережено у 'magazines.json'.");

            string loadedJson = MagazineLoadFromFile("magazines.json");
            List<MagazineInfo> loadedMagazines = DeserializeMagazineArray(loadedJson);

            Console.WriteLine("\nЗавантажені журнали з файлу:\n");
            foreach (MagazineInfo mag in loadedMagazines)
            {
                Console.WriteLine(mag);
                Console.WriteLine("-------------------------------\n");
            }
            #endregion
        }
        static string SerializeMagazineArray(List<MagazineInfo> magazines)
        {
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            return JsonSerializer.Serialize(magazines, options);
        }

        static void MagazineSaveToFile(string json, string filename)
        {
            File.WriteAllText(filename, json);
        }

        static string MagazineLoadFromFile(string filename)
        {
            return File.ReadAllText(filename);
        }

        static List<MagazineInfo> DeserializeMagazineArray(string json)
        {
            return JsonSerializer.Deserialize<List<MagazineInfo>>(json);
        }
        static Serialize.Fraction[] InputFractions()
        {
            Console.Write("Скільки дробів ви хочете ввести? ");
            string input = Console.ReadLine();
            int count = Convert.ToInt32(input);

            Serialize.Fraction[] array = new Serialize.Fraction[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Дріб #" + (i + 1));

                Console.Write("  Чисельник: ");
                string numeratorInput = Console.ReadLine();
                int numerator = Convert.ToInt32(numeratorInput);

                Console.Write("  Знаменник: ");
                string denominatorInput = Console.ReadLine();
                int denominator = Convert.ToInt32(denominatorInput);

                array[i] = new Serialize.Fraction(numerator, denominator);
            }

            return array;
        }

        static string SerializeFractions(Serialize.Fraction[] fractions)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            return JsonSerializer.Serialize(fractions, options);
        }

        static void SaveToFile(string json, string filename)
        {
            File.WriteAllText(filename, json);
        }

        static string LoadFromFile(string filename)
        {
            return File.ReadAllText(filename);
        }

        static Serialize.Fraction[] DeserializeFractions(string json)
        {
            return JsonSerializer.Deserialize<Serialize.Fraction[]>(json);
        }
    }
}