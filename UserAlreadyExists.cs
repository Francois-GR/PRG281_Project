using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRG
{
    class UserAlreadyExists: Exception
    {

        public UserAlreadyExists() { }

        public UserAlreadyExists(string message): base(message) { }

        public UserAlreadyExists(string message, Exception inner) : base(message, inner) { }
    }
}
