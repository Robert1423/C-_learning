using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize
{
    public class A
    {
        public string name { get; set; }
        public A(string n)
        {
            name = n;
        }
        public void Show()
        {
            Console.WriteLine($"Obiekt klasy A z name = {name}");
        }
    }
}
