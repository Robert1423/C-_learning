using System;
using System.Runtime.Serialization;

namespace Exceptions
{
    public class InvalidProcessingParameterException : ApplicationException
    {
        public int x;

        public InvalidProcessingParameterException()
        {
            Console.WriteLine("Parameter Error!");
        }

        public InvalidProcessingParameterException(int x)
        {
            this.x = x;
            Console.WriteLine($"Parametr {this.x} jest niepoprawny!");
        }

        public InvalidProcessingParameterException(string message) : base(message)
        {
        }
    }
}