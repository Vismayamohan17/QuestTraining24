using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ecoserver_server
{
    public class ServerBuilder
    {
        static void Main(string[] args)
        {
            var ip = IPAddress.Parse("127.0.0.1");
            var port = 8000;
            var listener = new TcpListener(ip, port);

            listener.Start();
            Console.WriteLine($"Server is listening...{ip}:{port}");

            var client = listener.AcceptTcpClient();
            Console.WriteLine("Client connected");

            var stream = client.GetStream();

            while (true)
            {
                var buffer = new byte[1024];
                var bytesRead = stream.Read(buffer, 0, buffer.Length);
                var message = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                Console.WriteLine($"Received message: {message}");

                stream.Write(buffer, 0, bytesRead);
                Console.WriteLine("Message echoed back to client");
            }


        }
    }
}
