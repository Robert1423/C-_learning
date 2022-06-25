using Plugin.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.SpacedOut
{
    public class Processor : IProcessor
    {
        public string Name { get; set; }

        public string Process(string str)
        {
            return String.Join(" ", str.ToArray());
        }
    }
}
