using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akka.ProofOfConcept.Shared
{
    public class HelloMessage
    {
        public HelloMessage(string message)
        {
            Message = message;
        }

        public string Message { get; private set; }
    }
}
