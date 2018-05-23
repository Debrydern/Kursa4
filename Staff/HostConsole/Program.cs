using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace HostConsole
{
   public class Program
    {
        static void Main(string[] args)
        {
            StartHost();
            
        }

        public static void StartHost()
        {
            using (var host = new ServiceHost(typeof(HostService.HostService1)))
            {
                host.Open();
                Console.WriteLine("Service started!");
               
                ConsoleKeyInfo b;
                do {
                    Console.WriteLine("\nPress Q to exit:");
                    b = Console.ReadKey();
                }
                while (b.Key != ConsoleKey.Q);
                
                host.Close();
            }

        }
    }
}
