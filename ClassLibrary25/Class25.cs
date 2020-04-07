using System;
using System.IO;

namespace TestProgram
{
    public static class Class25
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class25!");

            const string fileName = "TextFile25.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class26.Test();
        }
    }
}
