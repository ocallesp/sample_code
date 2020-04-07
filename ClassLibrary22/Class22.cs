using System;
using System.IO;

namespace TestProgram
{
    public static class Class22
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class22!");

            const string fileName = "TextFile22.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class23.Test();
        }
    }
}
