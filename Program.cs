//using System;
//namespace threadExample
//{
//    class threaddemo
//    {
//        public static void print()
//        {
//            //while (true)
//            //{
//            //    Console.Write("1");
//            //}
//            for (int i = 0; i < 5; i++)
//            {
//                Thread.Sleep(1000);
//                if (i == 2)
//                {
//                    Thread.
//                }
//                Console.Write("2");
//            }

//        }
//    static void Main(String[] args)
//        {
//            Thread newthreaddemo = new Thread(new ThreadStart(print));
//            newthreaddemo.Start();
//            //while (true)
//            //{
//            //    Console.Write("2");
//            //}

//        }
//    }

//}
//using System;
//using System.Threading;
//public class MyThread
//{
//    public void Thread1()
//    {
//        for (int i = 0; i < 10; i++)
//        {
//            Console.WriteLine(i);
//            Thread.Sleep(200);
//        }
//    }
//}
//public class ThreadExample
//{
//    public static void Main()
//    {
//        Console.WriteLine("Start of Main");
//        MyThread mt = new MyThread();
//        Thread t1 = new Thread(new ThreadStart(mt.Thread1));
//        Thread t2 = new Thread(new ThreadStart(mt.Thread1));

//        t1.Start();
//        t2.Start();
//        try
//        {
//            t1.Abort();
//            t2.Abort();
//        }
//        catch (ThreadAbortException tae)
//        {
//            Console.WriteLine(tae.ToString());
//        }
//        Console.WriteLine("End of Main");
//    }
//}
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread thread1 = new Thread(Count);
        Thread thread2 = new Thread(Count);

        thread1.Start(1);  // Start counting from 1
        thread2.Start(100); // Start counting from 100

        thread1.Join();  // Wait for thread1 to finish
        thread2.Join();  // Wait for thread2 to finish

        Console.WriteLine("Both threads have finished.");
    }

    static void Count(object start)
    {
        int startValue = (int)start;
        for (int i = startValue; i < startValue + 5; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000); // Simulate work with a 1-second delay
        }
    }
}
