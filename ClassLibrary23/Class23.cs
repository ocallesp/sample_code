using System;
using System.IO;

namespace TestProgram
{
    public static class Class23
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class23!");

            const string fileName = "TextFile23.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class24.Test();
        }
    }
}
