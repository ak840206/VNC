using System;

using Microsoft.AspNetCore.SignalR.Client;

namespace SignalRCoreClientConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:5001/chatHub")
                .Build();

            connection.StartAsync().Wait();

            connection.InvokeCoreAsync("Send", args: new[] { "Natalie", "I Love You" });

            connection.On("ReceiveMessage", (string userName, string message) =>
            {
                Console.WriteLine(userName);
                Console.WriteLine(message);
            });

            connection.On("AddMessage", (string message) =>
            {
                Console.WriteLine(message);
            });

            connection.On("AddUserMessage", (string userName, string message) =>
            {
                Console.WriteLine(userName);
                Console.WriteLine(message);
            });

            Console.ReadKey();
        }
    }
}
