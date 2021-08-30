using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRG
{
    class playerModeException : Exception
    {
        public playerModeException() { }

        public playerModeException(string message) : base(message) { }

        public playerModeException(string message, Exception inner) : base(message, inner) { }
    }
}
