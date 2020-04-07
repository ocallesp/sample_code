using System;
using System.IO;

namespace TestProgram
{
    public static class Class21
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class21!");

            const string fileName = "TextFile21.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class22.Test();
        }
    }
}
