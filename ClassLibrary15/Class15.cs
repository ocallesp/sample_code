using System;
using System.IO;

namespace TestProgram
{
    public static class Class15
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class15!");

            const string fileName = "TextFile15.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class16.Test();
        }
    }
}