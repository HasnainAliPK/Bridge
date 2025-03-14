using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace TCPServer
{
    class Server
    {
        static void Main(string[] args)
        {
            const int port = 5000;  // Server port
            TcpListener server = new TcpListener(IPAddress.Any, port);

            server.Start();
            Console.WriteLine($"Server is running on port {port}...");

            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                Thread clientThread = new Thread(() => HandleClient(client));
                clientThread.Start();
            }
        }

        static void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string command = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();

            Console.WriteLine($"Received command: {command}");
            byte[] response;

            if (command == "Random" || command == "Add" || command == "Subtract")
            {
                response = Encoding.UTF8.GetBytes("2: Input numbers");
                stream.Write(response, 0, response.Length);
                bytesRead = stream.Read(buffer, 0, buffer.Length);
                string numbers = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();

                string[] parts = numbers.Split(' ');
                if (parts.Length == 2 && int.TryParse(parts[0], out int num1) && int.TryParse(parts[1], out int num2))
                {
                    int result = 0;
                    if (command == "Random")
                    {
                        Random rnd = new Random();
                        result = rnd.Next(num1, num2 + 1);
                    }
                    else if (command == "Add")
                    {
                        result = num1 + num2;
                    }
                    else if (command == "Subtract")
                    {
                        result = num1 - num2;
                    }

                    response = Encoding.UTF8.GetBytes($"4: {result}");
                }
                else
                {
                    response = Encoding.UTF8.GetBytes("Error: Invalid input format");
                }
            }
            else
            {
                response = Encoding.UTF8.GetBytes("Error: Invalid command");
            }

            stream.Write(response, 0, response.Length);
            client.Close();
        }
    }
}
