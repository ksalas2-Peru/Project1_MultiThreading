using System;
using System.Threading;

class BasicThread
{
    static void PrintNumbers(object obj)
    {
        int threadNum = (int)obj;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Thread {threadNum}: {i}");
            Thread.Sleep(500);
        }
    }

    static void Main()
    {
        Thread t1 = new Thread(PrintNumbers);
        Thread t2 = new Thread(PrintNumbers);
        
        t1.Start(1);
        t2.Start(2);
        
        t1.Join();
        t2.Join();

        Console.WriteLine("Threads have finished execution.");
    }
}
