using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace SingletonDesignPattern
{
    public class Program
    {
        static void AccessSingleton()
        {
            SingletonClass singleton = SingletonClass.GetInstance();
            singleton.PrintMessage ($" Thread {Thread.CurrentThread.ManagedThreadId}");
        }
        static void Main(string[] args)
        {

            SingletonClass singleton1 = SingletonClass.GetInstance();
            Console.WriteLine(singleton1.GetHashCode());

            SingletonClass singleton2 = SingletonClass.GetInstance();
            Console.WriteLine(singleton2.GetHashCode());

            SingletonClass singleton3 = SingletonClass.GetInstance();
            Console.WriteLine(singleton3.GetHashCode());

            Thread[] threads = new Thread[5];
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(AccessSingleton);
                threads[i].Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            Console.WriteLine("All threads have completed successfully");

            Console.ReadLine();
        }
    }
}
