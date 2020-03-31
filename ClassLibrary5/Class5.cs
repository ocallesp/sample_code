using System;
using System.IO;

namespace TestProgram
{
    public static class Class5
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class5!");

            const string fileName = "TextFile5.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class6.Test();
        }
    }
}