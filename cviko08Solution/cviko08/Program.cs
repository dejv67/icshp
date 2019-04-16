using NDesk.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviko08
{
    class Program
    {

        static (string, int, bool) ProcessArgs(string[] args)
        {
            string ipAddress = Server.ipAdresa;
            string portStr = Server.port.ToString();
            bool showHelp = false;

            var options = new OptionSet
            {
                { "n|name=", "TCP server adres..", name => name = Server.ipAdresa},
                { "h|help", "show this message and exit", val => showHelp = val != null }
            };

            IList<string> extra = options.Parse(args);
            if(extra.Count > 0)
            {
                throw new ArgumentException("Illegal exception");
            }

            if (showHelp)
            {
                ShowHelp(options);
            }
            
            if(!int.TryParse(portStr,out int port))
            {
                port = Server.port;
            }
            return (ipAddress, port, showHelp);
        }


        static void Main(string[] args)
        {

            Console.Title = "TCP Server";
            Console.WriteLine("Starting TCP server");

            string ipAddress;
            int port;
            bool showHelp;

            try
            {
                (ipAddress, port, showHelp) = ProcessArgs(args);
                if (showHelp) return;
                StartTCPServer(ipAddress, port);

            }
            catch (OptionException e)
            {
                Console.WriteLine($"{Console.Title}: {e.Message}");
                Console.WriteLine($"Try '{Console.Title} --help' for more information.");
                return;

            }
        }

        private static void StartTCPServer(string ipAdress, int port)
        {
            Server server = new Server(new ConsoleMessageProcessor(), ipAdress, port);
        }

        private static void ShowHelp(OptionSet optionSet)
        {
            Console.WriteLine($"Usage: {Console.Title} [OPTIONS]");
            Console.WriteLine($"{Console.Title} is tool for directory analysis.");
            Console.WriteLine("Default directory is current.");
            Console.WriteLine("Default output is console.");
            Console.WriteLine();
            Console.WriteLine("Options:");
            optionSet.WriteOptionDescriptions(Console.Out);
        }
    }
}
