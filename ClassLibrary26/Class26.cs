using System;
using System.IO;

namespace TestProgram
{
    public static class Class26
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class26!");

            const string fileName = "TextFile26.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class27.Test();
        }
    }
}
