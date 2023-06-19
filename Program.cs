using System.Net;
using System.IO;
using System.Diagnostics;
using System;
using System.Threading;
using System.Linq;
using System.Reflection;

namespace ApollonUpdater
{
    class Program
    {
        static void Main()
        {
            if (IsApplicationAlreadyRunning())
            {
                Environment.Exit(0);
            }
            var client = new WebClient();
            string nameOfIt = client.DownloadString("TODO"); 
            string apis = client.DownloadString("TODO"); 
            string paping = client.DownloadString("TODO"); 
            string pinger = client.DownloadString("TODO"); 
            string extension = client.DownloadString("TODO");
            Random rnd = new Random();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Title = "Apollon Updater | Version: 1.0 | Name: " + Environment.UserName;
            Console.SetWindowSize(120, 30);
            Console.SetBufferSize(120, 30);
            Console.SetWindowPosition(0, 0);
            int time = rnd.Next(1450, 2250);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var dirName = $@"{path}\MasterTools\";
            var frere = dirName + "pinger.bat";
            var frere2 = dirName + "paping.exe";
            var frere3 = AppDomain.CurrentDomain.BaseDirectory + "pinger.bat";
            var frere4 = AppDomain.CurrentDomain.BaseDirectory + "paping.exe";
            if (!File.Exists("Master Tools.exe"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t                           _ _               _    _           _       _            ");
                Console.WriteLine("\t\t         /\\               | | |             | |  | |         | |     | |           ");
                Console.WriteLine("\t\t        /  \\   _ __   ___ | | | ___  _ __   | |  | |_ __   __| | __ _| |_ ___ _ __ ");
                Console.WriteLine("\t\t       / /\\ \\ | '_ \\ / _ \\| | |/ _ \\| '_ \\  | |  | | '_ \\ / _` |/ _` | __/ _ \\ '__|");
                Console.WriteLine("\t\t      / ____ \\| |_) | (_) | | | (_) | | | | | |__| | |_) | (_| | (_| | ||  __/ |   ");
                Console.WriteLine("\t\t     /_/    \\_\\ .__/ \\___/|_|_|\\___/|_| |_|  \\____/| .__/ \\__,_|\\__,_|\\__\\___|_|   ");
                Console.WriteLine("\t\t              | |                                  | |                             ");
                Console.WriteLine("\t\t              |_|                                  |_|                             ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\t\t\t\t\t\t   Made by Ambitionist");
                Console.WriteLine("\n\t\t\t\t\t\t     Version 1.0");
                Thread.Sleep(time);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\t\t\t\t\t\t   Download assets");
                Thread.Sleep(time);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\n\t\t\t\t\t\t   Download Modules");
                Thread.Sleep(time);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\t\t\t\t\t\t    Unpacking Data");
                Thread.Sleep(time);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n\t\t\t\t\t\t   Unpacking Modules");
                Thread.Sleep(time);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\t\t\t\t\t\t     Loading Data");
                Thread.Sleep(time);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\t\t\t\t\t\t    Loading Modules");
                Thread.Sleep(time);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n\t\t\t\t\t\t Launching Application");
                Thread.Sleep(3000);
                if (!Directory.Exists(dirName))
                {
                    Directory.CreateDirectory(dirName);
                }
                File.Delete(nameOfIt + extension);
                if (File.Exists(frere3))
                {
                    File.Delete(frere3);
                }
                if (File.Exists(frere4))
                {
                    File.Delete(frere4);
                }
                if (!File.Exists(frere2))
                {
                    client.DownloadFile(paping, "paping.exe");
                    File.Copy(frere4, frere2);
                }
                if (!File.Exists(frere))
                {
                    client.DownloadFile(pinger, "pinger.bat");
                    File.Copy(frere3, frere);
                }
                File.Delete(frere3);
                client.DownloadFile(apis, nameOfIt + extension);
                Process.Start(nameOfIt + extension);
                Process[] _proceses = null;
                _proceses = Process.GetProcessesByName("Master Tools");
                foreach (Process proces in _proceses)
                {
                    proces.Kill();
                }
            }
            else
            {
                Console.WriteLine("Opening");
                if (File.Exists(frere3))
                {
                    File.Delete(frere3);
                }
                if (File.Exists(frere4))
                {
                    File.Delete(frere4);
                }
                File.Delete(nameOfIt + extension);
                Environment.Exit(0);
            }

        }
        static bool IsApplicationAlreadyRunning()
        {
            return Process.GetProcesses().Count(p => p.ProcessName.Contains(Assembly.GetExecutingAssembly().FullName.Split(',')[0]) && !p.Modules[0].FileName.Contains("vshost")) > 1;
        }
    }
}
