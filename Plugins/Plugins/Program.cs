using Plugins.Configs;
using Plugins.Extractors;
using Plugins.UseCase;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Plugins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowdz tekst: ");
            string input = Console.ReadLine();
            var configBuilder = new ConfigBuild();
            var config = configBuilder.Build();
            var typeInfoExtract = new TypeInfoExtract();
            var typeInfos = typeInfoExtract.Extract(config);
            RunUseCase<BaseReflection>(typeInfos, input);
            Console.ReadKey();
        }

        private static void RunUseCase<T>(IEnumerable<TypeInfo> typeInfos, string text) where T : IUse, new()
        {
            T useCase = new T();
            foreach (var typeInfo in typeInfos)
            {
                useCase.Method(typeInfo, text);
            }
        }
    }
}
