using System;
using System.IO;

namespace TestProgram
{
    public static class Class6
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class6!");

            const string fileName = "TextFile6.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class7.Test();
        }
    }
}