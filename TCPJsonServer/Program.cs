using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TCPJsonServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int port = 5001;
            TcpListener server = new TcpListener(IPAddress.Any, port);

            server.Start();
            Console.WriteLine($"JSON Server running on port {port}...");

            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                HandleClient(client);
            }
        }

        static void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string requestJson = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();

            Console.WriteLine($"Received JSON: {requestJson}");
            var request = JsonConvert.DeserializeObject<JsonRequest>(requestJson);
            int result = 0;

            if (request.Command == "Random")
            {
                Random rnd = new Random();
                result = rnd.Next(request.Number1, request.Number2 + 1);
            }
            else if (request.Command == "Add")
            {
                result = request.Number1 + request.Number2;
            }
            else if (request.Command == "Subtract")
            {
                result = request.Number1 - request.Number2;
            }

            var response = new JsonResponse { Result = result };
            string responseJson = JsonConvert.SerializeObject(response);
            byte[] responseBytes = Encoding.UTF8.GetBytes(responseJson);
            stream.Write(responseBytes, 0, responseBytes.Length);

            client.Close();
        }

    }

    class JsonRequest
    {
        public string Command { get; set; }
        public int Number1 { get; set; }
        public int Number2 { get; set; }
    }

    class JsonResponse
    {
        public int Result { get; set; }
    }
}
