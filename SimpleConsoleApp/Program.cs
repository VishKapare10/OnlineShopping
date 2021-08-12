using System;
using System.Threading;

namespace SimpleConsoleApp
{
    //Multithreaded application
    class Program
    {
        static void StoreData(){
            Thread theThread = Thread.CurrentThread;
            Console.WriteLine("StoreData function thread ="+theThread.ManagedThreadId);  
            Console.WriteLine("Storing Data in json file");
            Thread.Sleep(3000);
            Console.WriteLine("Data has been successfully stored in file");
        }

        static void GetRemoteData(){
            Thread theThread = Thread.CurrentThread;
            Console.WriteLine("GetRemoteData function thread ="+theThread.ManagedThreadId);  
            Console.WriteLine("Getting users data from git repository");
            Thread.Sleep(4000);
            Console.WriteLine("Data has been received from remote server");
        }
        static void Main(string[] args)
        {
            //Primary thread
            Thread theThread = Thread.CurrentThread;
            Console.WriteLine("Main function invoker ="+theThread.ManagedThreadId);
            Thread.Sleep(5000);
            Display();

            //Creating 2 secondary threads using secondary .NET SDK.
            ThreadStart theDelegate1=new ThreadStart(StoreData);
            Thread thread2= new Thread(theDelegate1);

            ThreadStart theDelegate2=new ThreadStart(GetRemoteData);
            Thread thread3= new Thread(theDelegate2);

            thread2.Start();
            thread3.Start();

            Console.WriteLine("Main function is about to be terminated");
        }

        public static void Display(){
            Thread theThread = Thread.CurrentThread;
            Console.WriteLine("Display function thread ="+theThread.ManagedThreadId);  
            Console.WriteLine("Displaying product catalog data");
        }
    }
}
