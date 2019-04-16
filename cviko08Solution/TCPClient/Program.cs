using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            socket.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1200));
            while (true)
            {
                Console.Write("> ");
                string message = Console.ReadLine();
                byte[] data = Encoding.Default.GetBytes(message);
                socket.Send(data);
            }

        }
    }
}
