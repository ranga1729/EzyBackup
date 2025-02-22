using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.IO;
using Newtonsoft.Json;

namespace EzyBackup
{
    public class ApplicationData
    {
        private const string FilePath = "settings.json";

        public bool AutoBackup { get; set; }
        public List<InitializedDevice>? InitializedDeviceList { get; set; }

        private ApplicationData() { }

        public static ApplicationData Load()
        {
            if (File.Exists(FilePath))
            {
                try
                {
                    string json = File.ReadAllText(FilePath);
                    var loadedSettings = JsonConvert.DeserializeObject<ApplicationData>(json);
                    return loadedSettings ?? CreateDefault();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading settings: {ex.Message}");
                    return CreateDefault();
                }
            }
            else
            {
                var defaultSettings = CreateDefault();
                defaultSettings.Save();
                return defaultSettings;
            }
        }

        private static ApplicationData CreateDefault()
        {
            return new ApplicationData
            {
                AutoBackup = true,
                InitializedDeviceList = new List<InitializedDevice>()
            };
        }

        public void Save()
        {
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }
    }

}
