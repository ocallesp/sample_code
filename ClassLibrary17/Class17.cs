using System;
using System.IO;

namespace TestProgram
{
    public static class Class17
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class17!");

            const string fileName = "TextFile17.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class18.Test();
        }
    }
}