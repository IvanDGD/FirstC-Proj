using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.File_System
{
    internal class PoemList
    {
        private List<Poem> poems = new List<Poem>();

        public void AddPoem(Poem poem)
        {
            poems.Add(poem);
        }
        public void RemovePoem(string Name)
        {
            for (int i = 0; i < poems.Count; i++)
            {
                if (poems[i].poemName == Name)
                {
                    poems.RemoveAt(i);
                    return;
                }
            }
        }
        public void UpdatePoem(string title, Poem updatedPoem)
        {
            for (int i = 0; i < poems.Count; i++)
            {
                if (poems[i].poemName == title)
                {
                    poems[i] = updatedPoem;
                    return;
                }
            }
            Console.WriteLine("Poem not found.");
        }

        public void SearchPoems(string query)
        {
            foreach (Poem poem in poems)
            {
                if (poem.poemName.Contains(query) || poem.authorName.Contains(query) || poem.poemTheme.Contains(query))
                {
                    Console.WriteLine($"Title: {poem.poemName}, Author: {poem.authorName}, Year: {poem.yearOfWriting}, Theme: {poem.poemTheme}\n{poem.poemText}\n");
                }
            }
        }

        public void SaveToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Poem poem in poems)
                {
                    writer.WriteLine($"{poem.poemName}|{poem.authorName}|{poem.yearOfWriting}|{poem.poemText}|{poem.poemTheme}");
                }
            }
        }

        public void LoadFromFile(string filename)
        {
            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 5)
                    {
                        Poem poem = new Poem(parts[0], parts[1], int.Parse(parts[2]), parts[3], parts[4]);
                        poems.Add(poem);
                    }
                }
            }
        }
    }
}
