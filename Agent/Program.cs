using System;
using System.Management;

namespace Agent
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialProvider provider = new SerialProvider();
            Console.WriteLine(provider.GetSerial());
            Console.ReadKey();
        }
    }
}