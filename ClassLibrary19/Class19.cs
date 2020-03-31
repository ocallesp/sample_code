using System;
using System.IO;

namespace TestProgram
{
    public static class Class19
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class19!");

            const string fileName = "TextFile19.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }
        }
    }
}