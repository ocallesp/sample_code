using System;
using System.IO;

namespace TestProgram
{
    public static class Class7
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class1!");

            const string fileName = "TextFile7.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class8.Test();
        }
    }
}