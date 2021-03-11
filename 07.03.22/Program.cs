using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07._03._22
{
    class Program
    {
        //a:  
        //static ManualResetEvent host = new ManualResetEvent(false);

        //public static void EnterClub ()
        //{
        //    Console.WriteLine("Waiting to enter.");
        //    host.WaitOne();
        //    Console.WriteLine("I am in");
        //    //host.Set();
        //}

        //static void Main(string[] args)
        //{
        //    for (int i = 0; i < 50; i++)
        //    {
        //        new Thread(EnterClub).Start();
        //    }
        //    Thread.Sleep(3000);
        //    host.Set();
        //}

        //b:
        static AutoResetEvent host = new AutoResetEvent(false);
        public static void EnterClub()
        {
            Console.WriteLine("Waiting to enter.");
            host.WaitOne();
            Console.WriteLine("I am in");
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++)
            {
                new Thread(EnterClub).Start();
            }
            Thread.Sleep(3000);
            //Only three will enter one by one:
            host.Set();
            host.Set(); 
            host.Set();
        }
    }
}
