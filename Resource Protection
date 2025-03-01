using System;
using System.Threading;

class Program
{
    static Mutex mutex = new Mutex();
    static int sharedResource = 0;

    static void ModifyResource(object obj)
    {
        mutex.WaitOne(); // Lock resource
        int threadNum = (int)obj;
        sharedResource += 1;
        Console.WriteLine($"Thread {threadNum} modified resource: {sharedResource}");
        Thread.Sleep(1000);
        mutex.ReleaseMutex(); // Unlock resource
    }

    static void Main()
    {
        Thread t1 = new Thread(ModifyResource);
        Thread t2 = new Thread(ModifyResource);
        
        t1.Start(1);
        t2.Start(2);
        
        t1.Join();
        t2.Join();

        Console.WriteLine("Threads have finished execution.");
    }
}
