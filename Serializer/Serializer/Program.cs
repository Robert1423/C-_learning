using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializer
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "testdata.json";
            TestItem item = new TestItem();
            item._name = "Test";
            item._id = 2;
            Serializer<TestItem> serializer = new Serializer<TestItem>();
            Writer<TestItem> writer = new Writer<TestItem>(serializer);
            Reader<TestItem> reader = new Reader<TestItem>(serializer);
            writer.Write(item, file);
            TestItem restore = reader.Read(file);
            Console.WriteLine($"Po odczycie: name: {restore._name}, id: {restore._id}");
            Console.ReadKey();
        }
    }
}
