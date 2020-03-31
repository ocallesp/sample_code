using System;
using System.IO;

namespace TestProgram
{
    public static class Class2x
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class2x");

            const string fileName = "TextFile2x.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }
        }
    }
}