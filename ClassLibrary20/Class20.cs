using System;
using System.IO;

namespace TestProgram
{
    public static class Class20
    {
        public static void Test()
        {
            Console.WriteLine("Hello from   Class20!");

            const string fileName = "TextFile20.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }
        }
    }
}