using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace C0732134
{
    public class Prog
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Downloading a File.");
            ToDownload();            
            Console.ReadLine();
        }

        public static void ToDownload()
        {
            Task.Run(() =>                                                      // Anonymous Function
            {
                Thread.Sleep(2000);
                Console.WriteLine("Download Completed.....");

            });
            
        }
    }

   
}
