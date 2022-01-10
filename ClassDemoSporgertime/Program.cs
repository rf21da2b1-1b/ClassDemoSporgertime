using System;

namespace ClassDemoSporgertime
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelWorker worker = new ModelWorker();
            worker.Start();

            Console.WriteLine("Hello World!");
        }
    }
}
