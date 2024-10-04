using System.Net;
using System.Net.Sockets;

namespace Minecraft_Server
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(new IPEndPoint(IPAddress.Any, 25565));
            while (true)
            {
                server.Listen();
                Socket client = server.Accept();
                Thread serveracceptthread = new Thread(() => acceptconn(client));
                serveracceptthread.Start();
            }
        }
        public static void acceptconn(Socket client)
        {
            Console.WriteLine("connection recieved.");
        }
    }
}
