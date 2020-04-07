using System;
using System.IO;

namespace TestProgram
{
    public static class Class33
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class33!");

            const string fileName = "TextFile33.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class34.Test();
        }
    }
}
