using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Http;

namespace C0732134
{
    public class Prog
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Downloading a File.");
            Network net = new Network();
            net.ToDownload();
            Console.ReadLine();
        }

        public static async void ToDownloadAsync()
        {
            
            
            Console.WriteLine("Download Complete");
        }
    }

    class Network
    {
        public async void ToDownload()
        {
            HttpClient client = new HttpClient();
            var data = await client.GetStringAsync("https://github.com/hps3103/March29/blob/master/C0732134/Program.cs");
            Console.WriteLine(data);
        }
       
    }



}
