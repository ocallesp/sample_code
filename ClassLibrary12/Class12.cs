using System;
using System.IO;

namespace TestProgram
{
    public static class Class12
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class12!");

            const string fileName = "TextFile12.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class13.Test();
        }
    }
}