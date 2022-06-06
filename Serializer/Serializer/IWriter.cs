using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializer
{
    interface IWriter<in T>
    {
        void Write(T obj, string fileName);
    }
}
