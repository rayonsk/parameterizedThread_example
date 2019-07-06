using System;
using System.Threading;

namespace threadTest_2
{
    class Program
    {
        public static void childThread(object obj)
        {
            for (int i = 0; i < (int)obj; i++)
            {
                Console.WriteLine("the thread = {0}", i);
                Thread.Sleep(0);
            }
        }
        static void Main(string[] args)
        {
            Thread tobj = new Thread(new ParameterizedThreadStart(childThread));
            tobj.Start(5);

            //Console.ReadLine();

        }
    }
}
