using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Serialize
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "data.json";
            //C test = new C("SerializeLearning");
            //for (int i = 0; i < 20; i++)
            //{
            //    A x = new A("test" + i.ToString());
            //    test.Add(x);
            //}
            //test.Show();
            //serializacja przez metodę klasy
            //test.Save(filename);
            //serializacja
            //string result = JsonConvert.SerializeObject(test);
            //File.WriteAllText(filename, result);
            //Console.WriteLine("RESULT:");
            //Console.WriteLine(result);
            //deserializacja
            //string fromFile = File.ReadAllText(filename);
            //C des = JsonConvert.DeserializeObject<C>(fromFile);
            C des = new C();
            //deserializacja przez metodę
            des.Load(filename);
            des.Show();
            //Console.ReadKey();
        }
    }
}
