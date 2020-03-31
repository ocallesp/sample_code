using System;
using System.IO;

namespace TestProgram
{
    public static class Class18
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class18!");

            const string fileName = "TextFile18.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class19.Test();
        }
    }
}