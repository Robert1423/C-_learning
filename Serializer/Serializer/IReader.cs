using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializer
{
    interface IReader<out T>
    {
        T Read(string fileName);
    }
}
