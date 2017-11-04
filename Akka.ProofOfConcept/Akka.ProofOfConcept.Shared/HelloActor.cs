using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;

namespace Akka.ProofOfConcept.Shared
{
    public class HelloActor : ReceiveActor
    {
        public HelloActor()
        {
            Receive<HelloMessage>(msg =>
            {
                Console.WriteLine(msg.Message);
            });
        }
    }
}
