using System;
using System.IO;

namespace TestProgram
{
    public static class Class31
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class31!");

            const string fileName = "TextFile31.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class32.Test();
        }
    }
}
