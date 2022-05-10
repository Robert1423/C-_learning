using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Serialize
{
    public class C
    {
        public B _b { get; set; }
        public string _name { get; set; }
        public C(string name)
        {
            _b = new B();
            _name = name;
        }
        public C()
        {
            _b = new B();
            _name = "";
        }
        public void Add(A a)
        {
            _b.Add(a);
        }
        public void Show()
        {
            Console.WriteLine(_name);
            _b.Show();
        }
        public void Save(string filePath)
        {
            if (File.Exists(filePath)) File.Delete(filePath);
            File.WriteAllText(filePath, JsonConvert.SerializeObject(this));
        }
        public void Load(string filePath)
        {
            C temp = JsonConvert.DeserializeObject<C>(File.ReadAllText(filePath));
            _b = temp._b;
            _name = temp._name;
        }
    }
}
