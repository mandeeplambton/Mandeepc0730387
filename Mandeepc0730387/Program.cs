﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mandeepc0730387
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mandeep Kaur Rules the IT Universe!");
            Download();
            Console.ReadLine();
        }

        static async void Download()
        {
           await Network.Download();
            Console.WriteLine("Download completed");
        }
        class Network
        {
            static public Task Download()
            {
                return Task.Run(() => Thread.Sleep(3000));
            }
        }
    }
}