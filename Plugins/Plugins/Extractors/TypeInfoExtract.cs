using Plugin.Contracts;
using Plugins.Configs;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Plugins.Extractors
{
    class TypeInfoExtract
    {
        public IEnumerable<TypeInfo> Extract(Config configuration)
        {
            var typeInfos = new List<TypeInfo>();
            foreach (var path in configuration.pluginsPaths)
            {
                var assembly = Assembly.LoadFile(path);
                var formatterTypeInfos = assembly.DefinedTypes.Where(
                    x => x.IsClass
                      && x.ImplementedInterfaces.Any(y => y.FullName == typeof(IProcessor).FullName)
                      && !x.IsAbstract);

                if (formatterTypeInfos.Any())
                {
                    typeInfos.AddRange(formatterTypeInfos);
                }
            }

            return typeInfos;
        }
    }
}
