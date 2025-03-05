namespace Assessmentc_
{
    public sealed class ConfigurationManager
    {
        private static readonly Lazy<ConfigurationManager> instance = new Lazy<ConfigurationManager>(() => new ConfigurationManager());

        // Private constructor to prevent instantiation from outside
        private ConfigurationManager()
        {
        }

        public static ConfigurationManager Instance
        {
            get
            {
                return instance.Value;
            }
        }

        // Configuration properties
        private Dictionary<string, string> settings = new Dictionary<string, string>();

        // Method to get a configuration value
        public string GetSetting(string key)
        {
            if (settings.ContainsKey(key))
            {
                return settings[key];
            }
            return null;
        }

        // Method to set a configuration value
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
        }

        // Method to remove a configuration value
        public bool RemoveSetting(string key)
        {
            return settings.Remove(key);
        }

        // Method to clear all configuration values
        public void ClearSettings()
        {
            settings.Clear();
        }
    }

    
}
