using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FirstC_Proj.SOLID
{
    internal class AppConfig
    {
        private static AppConfig instance;
        private static readonly object lockObj = new object();

        private Dictionary<string, string> settings;
        private const string filePath = "appsettings.json";

        private AppConfig()
        {
            settings = new Dictionary<string, string>();
            LoadSettings();
        }

        public static AppConfig GetInstance()
        {
            if (instance == null)
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new AppConfig();
                    }
                }
            }
            return instance;
        }

        public void SetSetting(string key, string value)
        {
            if (settings.ContainsKey(key))
            {
                settings[key] = value;
            }
            else
            {
                settings.Add(key, value);
            }
            SaveSettings();
        }

        public string GetSetting(string key)
        {
            if (settings.ContainsKey(key))
            {
                return settings[key];
            }
            return null;
        }

        private void SaveSettings()
        {
            try
            {
                string json = JsonSerializer.Serialize(settings, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving settings: " + ex.Message);
            }
        }

        private void LoadSettings()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    settings = JsonSerializer.Deserialize<Dictionary<string, string>>(json);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading settings: " + ex.Message);
            }
        }
    }
}
