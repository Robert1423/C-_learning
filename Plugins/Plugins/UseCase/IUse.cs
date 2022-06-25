using System.Reflection;

namespace Plugins.UseCase
{
    internal interface IUse
    {
        void Method(TypeInfo typeInfo, string text);
    }
}
