using System;
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
            Console.WriteLine("Mandeep kaur rules the IT universe"); Download();
        }

        static void Download()
        {
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Download Complete");
            }
            );


        }
    }
}