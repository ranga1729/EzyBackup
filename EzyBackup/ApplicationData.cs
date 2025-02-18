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
        public static string FilePath => "settings.json";

        public bool AutoBackup { get; set; }
        public List<InitializedDevice>? InitializedDeviceList { get; set; }

        public ApplicationData()
        {
            if (File.Exists(FilePath))
            {
                try
                {
                    string json = File.ReadAllText(FilePath);
                    var loadedSettings = JsonConvert.DeserializeObject<ApplicationData>(json) ?? new ApplicationData();

                    this.AutoBackup = loadedSettings.AutoBackup;
                    this.InitializedDeviceList = loadedSettings.InitializedDeviceList ?? new List<InitializedDevice>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading settings: {ex.Message}");
                    SetDefaults();
                }
            }
            else
            {
                SetDefaults();
                Save();
            }
        }

        private void SetDefaults()
        {
            AutoBackup = true;
            InitializedDeviceList = new List<InitializedDevice>();
        }

        public void Save()
        {
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }
    }
}
