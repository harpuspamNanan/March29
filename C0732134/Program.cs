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
            ToDownload();
            
            Console.ReadLine();
        }

        public static void ToDownload()
        {
            Thread.Sleep(3000);
        }
    }

    public class HelloWorld
    {

        public void sayHello()
        {
            Console.WriteLine("Hello World!");
        }

       
    }
}
