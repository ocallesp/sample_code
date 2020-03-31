using System;
using System.IO;

namespace TestProgram
{
    public static class Class8
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class8!");

            const string fileName = "TextFile8.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class9.Test();
        }
    }
}