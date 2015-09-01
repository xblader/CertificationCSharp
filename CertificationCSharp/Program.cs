using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CertificationCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //thread 2.0

            Thread thread = new Thread(new ThreadStart(Run));
            thread.Start();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(0);
            }
            thread.Join();
            Console.ReadKey();
        }

        public static void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }
    }
}
