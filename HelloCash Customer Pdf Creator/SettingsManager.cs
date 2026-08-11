using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HelloCash_Customer_Pdf_Creator
{
    public static class SettingsManager
    {
        [Serializable]
        public struct Settings
        {
            public string OutputPath { get; set; }
            public string APIKey { get; set; }
        }

        private static Settings currentSettings;

        public static void LoadSettings()
        {
            if (!File.Exists(Path.Combine(Values.Root, "settings.json")))
            {
                GenerateNewSettings();
            }

            currentSettings = JsonSerializer.Deserialize<Settings>(File.ReadAllText(Path.Combine(Values.Root, "settings.json")));
            Values.OutputPath = currentSettings.OutputPath;
            Values.API_Key = currentSettings.APIKey;
        }

        public static void SaveSettings(Settings newSettings)
        {
            File.WriteAllText(Path.Combine(Values.Root, "settings.json"), JsonSerializer.Serialize(newSettings));
            LoadSettings();
        }

        public static void GenerateNewSettings()
        {
            var settings = new Settings { OutputPath = Path.Combine(Values.Root, "Output"), APIKey = "" };
            File.WriteAllText(Path.Combine(Values.Root, "settings.json"), JsonSerializer.Serialize(settings));
            MessageBox.Show("No Settings Found, Generating new Settings File");
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.Show();
        }
    }
}
