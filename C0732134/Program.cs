using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Http;
using System.Collections;

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

        static async void ToDownloadAsync()
        {
            await Network.ToDownload();            
            Console.WriteLine("Download Complete");
        }
    }

    class Network
    {
        ArrayList WebPageContents = new ArrayList();

        public static async Task ToDownload()
        {
            HttpClient client = new HttpClient();
            string data = await client.GetStringAsync("https://github.com/hps3103/March29/blob/master/C0732134/Program.cs");
           
            Console.WriteLine(data);
        }
       
    }



}
