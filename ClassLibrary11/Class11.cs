using System;
using System.IO;

namespace TestProgram
{
    public static class Class11
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class11!");

            const string fileName = "TextFile11.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class12.Test();
        }
    }
}
