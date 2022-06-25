using Plugin.Contracts;
using System;
using System.Reflection;

namespace Plugins.UseCase
{
    internal class BaseReflection : IUse
    {
        public void Method(TypeInfo typeInfo, string text)
        {
            var instance = Activator.CreateInstance(typeInfo);
            var methodInfo = typeInfo.GetMethod(nameof(IProcessor.Process));
            Console.WriteLine(methodInfo.Invoke(instance, new object[] { text }));
        }
    }
}
