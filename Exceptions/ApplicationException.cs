using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class ApplicationException : Exception
    {
        public ApplicationException()
        {
            Console.WriteLine("Application Error!");
        }

        public ApplicationException(string message) : base(message)
        {
        }

        public new string Message()
        {
            return base.Message;
        }
    }
}
