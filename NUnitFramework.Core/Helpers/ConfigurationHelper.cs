using System.Configuration;

namespace TestFramework.Core.Helpers
{
    public static class ConfigurationHelper 
    {
        public static T GetValue<T>(string key)
        {
            var value = ConfigurationManager.AppSettings[key];
            if (value == null)
            {
                return default;
            }
            
            return (T)Convert.ChangeType(value, typeof(T));
        }
    }
}
