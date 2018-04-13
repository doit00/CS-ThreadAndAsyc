using System;
using System.Threading;

namespace Demos
{
    class ThreadAndDelegates
    {
        public static void AsyncDelegate()
        {
            Action<int> methodToCall = Count;
            AsyncCallback callback = ar => Console.WriteLine(ar.AsyncState);
            string state = "Count method";
            var r = methodToCall.BeginInvoke(3, callback, state);
            while (!r.IsCompleted)
            {
                Console.WriteLine("Main thread waiting");
                Thread.Sleep(400);
            }
        }
        public static void SimpleThread()
        {
            var dt = DateTime.Now;
            ParameterizedThreadStart pts = new ParameterizedThreadStart(Count);
            Thread t2 = new Thread(Count);
            t2.Start(5);
            t2.Join();
            Console.WriteLine(DateTime.Now - dt);
        }

        static void Count(int max)
        {
            for (int i = 0; i < max; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine(i);
            }
        }

        static void Count(object max)
        {
            int m = System.Convert.ToInt32(max);
            for (int i = 0; i < m; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine(i);
            }
        }


    }
}
