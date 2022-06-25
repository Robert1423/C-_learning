using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.Contracts
{
    public interface IProcessor
    {
        string Name { get; set; }
        string Process(string str);
    }
}
