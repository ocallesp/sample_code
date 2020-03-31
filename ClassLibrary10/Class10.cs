using System;
using System.IO;

namespace TestProgram
{
    public static class Class10
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class10!");

            const string fileName = "TextFile10.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class11.Test();
        }
    }
}
