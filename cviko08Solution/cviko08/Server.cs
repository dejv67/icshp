using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace cviko08
{
    class Server
    {

        public const string ipAdresa = "127.0.0.1";
        public const int port = 1200;
        public const int ListenerCount = 1;

        private IMessageProcessor processor;

        public Server(IMessageProcessor processor, string adresa, int port)
        {
            this.processor = processor;
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ipAdresa), port);
            processor?.Process($"TCP Server listening on {endPoint.ToString()}");
            socket.Bind(endPoint);

            socket.Listen(ListenerCount);

            Socket acceptedSocket = socket.Accept();
            byte[] acceptedData = new byte[acceptedSocket.SendBufferSize];
            int bufferCount = acceptedSocket.Receive(acceptedData);
            byte[] data = new byte[bufferCount];
            for (int i = 0; i < bufferCount; i++)
            {
                data[i] = acceptedData[i];
            }
            string message = Encoding.Default.GetString(data);
            processor?.Process(message);
        }

        public void Listen()
        {
            
        }

    }
}
