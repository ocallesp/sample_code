using System;
using System.IO;

namespace TestProgram
{
    public static class Class14
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class14!");

            const string fileName = "TextFile14.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class15.Test();
        }
    }
}