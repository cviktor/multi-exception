using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Hiba
{
    public class ParseException : FormatException
    {
        public char Character { get; private set; }

        public ParseException(char c)
        {
            Character = c;
        }

        public ParseException(char c, string message) : base(message)
        {
            Character = c;
        }

        public ParseException(char c, string message, Exception innerException) : base(message, innerException)
        {
            Character = c;
        }
    }
}
