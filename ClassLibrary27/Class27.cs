using System;
using System.IO;

namespace TestProgram
{
    public static class Class27
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class27!");

            const string fileName = "TextFile27.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class28.Test();
        }
    }
}

