using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRG
{
    class validationException :Exception
    {

        public validationException()
        { }

        public validationException(string message) : base(message) { }

        public validationException(string message, Exception inner): base(message, inner) { }



    }
}
