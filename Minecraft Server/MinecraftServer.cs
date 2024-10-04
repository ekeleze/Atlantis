using System.Net;
using System.Net.Sockets;
using Minecraft_Server.Packets;

namespace Minecraft_Server
{

    internal class MinecraftServer
    {
        public static Logger logger;
        public static Properties serverProperties;
        public static bool serverRunning { get; private set; }
        public static bool onlineMode;
        public static bool spawnPeacefulMobs;
        public static bool pvpOn;
        public static bool allowFlight;

        public static void Main(string[] args)
        {
            logger = new Logger();
            serverProperties = new Properties();
            serverRunning = true;

            logger.Info("Starting minecraft server version Beta 1.7.3");
        }

        #region Fully Implemented
        public void initiateShutdown()
        {
            serverRunning = false;
        }

        public String getUsername()
        {
            return "CONSOLE";
        }
        #endregion

        #region Needs Implementation
        private bool startServer()
        {
            // Needs implementation
            if (onlineMode == false)
            {
                logger.Warn("**** SERVER IS RUNNING IN OFFLINE/INSECURE MODE!");
                logger.Warn("The server will make no attempt to authenticate usernames. Beware.");
                logger.Warn("While this makes the game possible to play without internet access, it also opens up the ability for hackers to connect with any username they choose.");
                logger.Warn("To change this, set \"online-mode\" to \"true\" in the server.settings file.");
            }

            return false;
        }

        private void stopServer()
        {
            logger.Info("Stopping server");
            // Needs implementation
        }

        public void Run()
        {
            // Needs Implementation
        }
        #endregion

        #region Unused stuff
        /* public static void acceptconn(Socket client)
        {
            Console.WriteLine("connection recieved.");
        }

        
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(new IPEndPoint(IPAddress.Any, 25565));

            while (true)
            {
                server.Listen();
                Socket client = server.Accept();
                Thread serveracceptthread = new Thread(() => acceptconn(client));
                serveracceptthread.Start();
            }
        */
        #endregion
    }
}
