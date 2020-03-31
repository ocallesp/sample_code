using System;
using System.IO;

namespace TestProgram
{
    public static class Class1
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class1!");

            const string fileName = "TextFile1.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class2.Test();
        }
    }
}