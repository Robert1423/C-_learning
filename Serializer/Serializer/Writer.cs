using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializer
{
    public class Writer<T> : IWriter<T>
    {
        private readonly ISerializer<T> _serializer;
        public Writer(ISerializer<T> serializer)
        {
            _serializer = serializer;
        }
        public void Write(T obj, string fileName)
        {
            using(var fileStream = new FileStream(fileName,FileMode.Truncate,FileAccess.Write))
            {
                using(var streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.WriteLine(_serializer.Serialize(obj));
                }
            }
        }
    }
}
