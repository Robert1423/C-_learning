using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Serializer
{
    public class Serializer<T> : ISerializer<T>
    {
        public T Deserialize(string content)
        {
            return JsonSerializer.Deserialize<T>(content);
        }

        public string Serialize(T obj)
        {
            return JsonSerializer.Serialize(obj);
        }
    }
}
