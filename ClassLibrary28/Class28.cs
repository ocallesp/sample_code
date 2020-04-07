using System;
using System.IO;

namespace TestProgram
{
    public static class Class28
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class28!");

            const string fileName = "TextFile28.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class29.Test();
        }
    }
}
