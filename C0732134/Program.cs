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
            ToDownloadAsync();            
            Console.ReadLine();
        }

        public static async void ToDownloadAsync()
        {
            await Network.ToDownload();
            Console.WriteLine("Download Complete");
        }
    }

    class Network
    {
        static public Task ToDownload()
        {
            return Task.Run(() => Thread.Sleep(3000)); 
        }
    }



}
