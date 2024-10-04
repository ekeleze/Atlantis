﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Server
{
    internal class Logger
    {
        public void Info(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[INFO] ");
            Console.ForegroundColor = ConsoleColor.White; 
            Console.WriteLine(text);
        }

        public void Warn(string text) 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[WARN] ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(text);
        }

        public void Error(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[ERROR] ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(text);
        }

        public void Fatal(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("[FATAL] ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(text);
        }
    }
}
