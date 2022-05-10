using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class OptionProcessor
    {
        public void Process(int x)
        {
            if (x % 2 == 0)
                throw new InvalidProcessingParameterException(x);
        }
    }
}
