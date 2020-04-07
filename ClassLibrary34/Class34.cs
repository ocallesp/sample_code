using System;
using System.IO;

namespace TestProgram
{
    public static class Class34
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class34!");

            const string fileName = "TextFile34.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class35.Test();
        }
    }
}
