using System;

namespace dotnetcore_stacktrace
{
    class Program
    {
        static void Main(string[] args)
        {
            new RaiseException("");
            new RaiseException("Custom exception");
            Console.WriteLine("Logs sent to loggly. Press any key to exit application");
            Console.ReadKey();
        }
    }
}
