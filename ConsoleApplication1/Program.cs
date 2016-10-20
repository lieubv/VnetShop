using SuperSocket.SocketBase;
using SuperSocket.SocketEngine;
using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is my first server");
            Console.WriteLine("Press any key to start the server now ...");
            Console.ReadKey();
            Console.WriteLine();

            var bootstrap = BootstrapFactory.CreateBootstrap();

            if (!bootstrap.Initialize())
            {
                Console.WriteLine("Failed to initialize bootstrap!");
                Console.ReadKey();
                return;
            }

            var result = bootstrap.Start();
            
            Console.WriteLine("Start bootstrap result: {0}!", result);

            if (result == StartResult.Failed)
            {
                Console.WriteLine("Failed to start bootstrap!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Press key 'q' to stop the server!");
            while (Console.ReadKey().KeyChar != 'q')
            {
                Console.WriteLine();
                continue;
            }
            // Stop the server now

            bootstrap.Stop();

            Console.WriteLine("The server was stopped!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}