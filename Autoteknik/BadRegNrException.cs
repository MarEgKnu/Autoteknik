using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik
{
    public class BadRegNrException : Exception
    {
        public BadRegNrException(string message) : base(message)
        {
        }
    }
}
