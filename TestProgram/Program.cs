using System;
using LibraryA;

namespace TestProgram
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World! ");
            ClassA.Test();
            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }
}
