using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Diagnostics;
using System.IO;

namespace TeamSpeak3_Blacklist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Discord : Macius#8300";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();

            Console.Write("Dilinizi Seçiniz. (TR/EN)\nSelect your language. (EN/TR)\n: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            string dil = Convert.ToString(Console.ReadLine());
            string dogrulama = null;
            if (dil.ToUpper() == "TR")
            {
                 dogrulama = "Teamspeak 3 blacklist sorununun çözülmesini onaylıyor musunuz? (E/H)";

            }
            else if (dil.ToUpper() == "EN")
            {
                 dogrulama = "Do you confirm that the Teamspeak 3 blacklist issue is resolved ? (Y/N)";
            }
            else
            {
                Console.Clear();
                Environment.Exit(0);

            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("{0} : ", dogrulama);
            string cevap = Convert.ToString(Console.ReadLine());
            if (cevap.ToUpper() == "E" || cevap.ToUpper() == "Y") 
            {
                System.Threading.Thread.Sleep(1000);
                if (System.IO.File.Exists(@"C:\Windows\System32\drivers\etc\hosts"))
                {
                    System.IO.File.Delete(@"C:\Windows\System32\drivers\etc\hosts");
                }

                System.Threading.Thread.Sleep(1000);
                foreach (var process in Process.GetProcessesByName("ts3client_win64"))
                {
                    process.Kill();
                }

                //   WebClient webClient = new WebClient();
                //     webClient.DownloadFile("link", @"C:\konum");


                string dosya_yolu = @"C:\Windows\System32\drivers\etc\hosts";
                FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("# Copyright (c) 1993-2009 Microsoft Corp.\n#\n# This is a sample HOSTS file used by Microsoft TCP/IP for Windows.\n#\n# This file contains the mappings of IP addresses to host names. Each\n# entry should be kept on an individual line. The IP address should\n# be placed in the first column followed by the corresponding host name.\n# The IP address and the host name should be separated by at least one\n# space.\n#\n# Additionally, comments (such as these) may be inserted on individual\n# lines or following the machine name denoted by a '#' symbol.\n#\n# For example:\n#\n#      102.54.94.97     rhino.acme.com          # source server\n#       38.25.63.10     x.acme.com              # x client host\n# localhost name resolution is handled within DNS itself.\n#	127.0.0.1       localhost\n#	::1             localhost\n0.0.0.0 blacklist2.teamspeak.com");
                sw.Flush();
                sw.Close();
                fs.Close();

                System.Threading.Thread.Sleep(1000);

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                if (cevap.ToUpper() == "E")
                {

                    Console.WriteLine("Teamspeak 3 kapatıldı!");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Gerekli bileşenler kuruldu.");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Teamspeak 3 Blacklist sorunu başarıyla çözüldü. Uygulamayı kapatabilirsiniz.");
                    System.Threading.Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("########################################################################################");
                    System.Threading.Thread.Sleep(2000);
                        
                }
                else
                {
                    Console.WriteLine("Teamspeak 3 has been shut down!");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Required components have been installed.");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Teamspeak 3 Blacklist issue has been successfully resolved.You can close the application.");
                    System.Threading.Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("#########################################################################################");
                    System.Threading.Thread.Sleep(2000);
                }
            }
            else
            {
                Console.Clear();
                Environment.Exit(0);
            }
            Console.ReadKey();

        }
    }
}
