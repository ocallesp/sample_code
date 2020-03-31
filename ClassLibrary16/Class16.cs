using System;
using System.IO;

namespace TestProgram
{
    public static class Class16
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class16!");

            const string fileName = "TextFile16.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class17.Test();
        }
    }
}