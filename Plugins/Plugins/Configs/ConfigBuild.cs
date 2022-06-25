using Newtonsoft.Json;
using System.IO;
using System.Reflection;

namespace Plugins.Configs
{
    internal class ConfigBuild
    {
        private const string _configurationFileName = "config.json";
        public Config Build()
        {
            var currentAssembly = Assembly.GetExecutingAssembly();
            var assemblyPath = currentAssembly.Location;
            var assemblyFilename = Path.GetFileName(assemblyPath);
            var configurationFilePath = assemblyPath.Replace(assemblyFilename, _configurationFileName);
            var content = File.ReadAllText(configurationFilePath);
            return JsonConvert.DeserializeObject<Config>(content);
        }
    }
}
