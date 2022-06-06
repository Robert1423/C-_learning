using System.IO;

namespace Serializer
{
    public class Reader<T> : IReader<T>
    {
        private readonly ISerializer<T> _serializer;
        public Reader(ISerializer<T> serializer)
        {
            _serializer = serializer;
        }
        public T Read(string fileName)
        {
            using(var fileStream = new FileStream(fileName,FileMode.OpenOrCreate,FileAccess.Read))
            {
                using(var streamReader = new StreamReader(fileStream))
                {
                    string content = streamReader.ReadToEnd();
                    return _serializer.Deserialize(content);
                }
            }
        }
    }
}
