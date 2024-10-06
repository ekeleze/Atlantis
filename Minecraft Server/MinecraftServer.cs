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

        public static void Main(string[] args)
        {
            logger = new Logger();
            serverProperties = new Properties();
            serverRunning = true;

            logger.Info("Starting minecraft server version Beta 1.7.3");

            logger.Info("Loading properties");

            serverProperties = new Properties();
            string[] properties = File.ReadAllLines("server.properties");

            for (int i = 0; i < properties.Length; i++) {
                serverProperties.AddPropertyFromLine(properties[i]);
            }

            string serverIp = serverProperties.GetProperty("server-ip") == null ? string.Empty : (string) serverProperties.GetProperty("server-ip");
            onlineMode = serverProperties.GetProperty("online-mode") == null ? true : (bool) serverProperties.GetProperty("online-mode");
            spawnPeacefulMobs = serverProperties.GetProperty("spawn-animals") == null ? true : (bool) serverProperties.GetProperty("spawn-animals");
            pvpOn = serverProperties.GetProperty("pvp") == null ? true : (bool) serverProperties.GetProperty("pvp");
            allowFlight = serverProperties.GetProperty("allow-flight") == null ? false : (bool) serverProperties.GetProperty("allow-flight");
            int serverPort = serverProperties.GetProperty("server-port") == null ? 25565 : (int) serverProperties.GetProperty("server-port");

            logger.Info("Starting Minecraft server on " + (serverIp == string.Empty ? "*" : serverIp) + ":" + serverPort);

            if (onlineMode == false)
            {
                logger.Warn("**** SERVER IS RUNNING IN OFFLINE/INSECURE MODE!");
                logger.Warn("The server will make no attempt to authenticate usernames. Beware.");
                logger.Warn("While this makes the game possible to play without internet access, it also opens up the ability for hackers to connect with any username they choose.");
                logger.Warn("To change this, set \"online-mode\" to \"true\" in the server.settings file.");
            }

            while (true) { }
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
