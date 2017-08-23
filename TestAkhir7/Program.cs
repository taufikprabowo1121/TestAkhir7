using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAkhir7
{
  
    class Program
    {
        static void info()
        {
            Console.Write("ketik naon we : ");
        }
        static void Main(string[] args)
        {
            string url;
            string validasi;
            info();
            WebClient webClient = new WebClient();
            ConsoleKeyInfo cki = Console.ReadKey();
         
            try
            {
                Console.Write("Masukan Link :");
                url = Console.ReadLine();
                webClient.DownloadFile(new Uri(url), @"d:\start\taufik.jpeg");
                
            }
            catch(WebException e)
            {
                Console.WriteLine("Download Gagal {0}", e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("Downlod Berhasil");
                Console.ReadKey();
            }
        }
      

    }
}
