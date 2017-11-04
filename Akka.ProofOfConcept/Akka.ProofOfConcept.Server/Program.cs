using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using Akka.Configuration;
using Akka.ProofOfConcept.Shared;

namespace Akka.ProofOfConcept.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = ConfigurationFactory.ParseString(File.ReadAllText("server.conf"));
            using (var system = ActorSystem.Create("Server", config))
            {
                system.ActorOf<HelloActor>("EchoServerActor");
                Console.ReadLine();
            }
        }
    }
}
