using System;
using System.IO;

namespace TestProgram
{
    public static class Class9
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class9!");

            const string fileName = "TextFile9.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class10.Test();
        }
    }
}