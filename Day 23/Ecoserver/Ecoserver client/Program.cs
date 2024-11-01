using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ecoserver_client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ip = IPAddress.Parse("127.0.0.1");
            var port = 8000;
            var client = new TcpClient();

            client.Connect(ip, port);
            Console.WriteLine("Connecting to server...");

            while (true)
            {
                Console.Write("Client: ");
                var message = Console.ReadLine();

                var data = Encoding.ASCII.GetBytes(message);
                var stream = client.GetStream();
                stream.Write(data, 0, data.Length);

                var response = new byte[1024];
                var bytesRead = stream.Read(response, 0, response.Length);
                var responseText = Encoding.ASCII.GetString(response, 0, bytesRead);

                Console.WriteLine("Echo from server: " + responseText);
            }
        }
    }
}
