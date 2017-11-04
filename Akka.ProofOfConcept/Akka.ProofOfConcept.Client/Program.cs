using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using Akka.Configuration;
using Akka.ProofOfConcept.Shared;

namespace Akka.ProofOfConcept.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = ConfigurationFactory.ParseString(File.ReadAllText("client.conf"));

            using (var system = ActorSystem.Create("Client", config))
            {
                var remoteActor = system.ActorSelection("akka.tcp://Server@localhost:8081/user/EchoServerActor");
               
                while (true)
                {
                    Console.WriteLine("Type Message:");
                    string msg = Console.ReadLine();
                    var hello = new HelloMessage(msg);
                    remoteActor.Tell(hello);
                }
            }
        }
    }
}
