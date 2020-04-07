using System;
using System.IO;

namespace TestProgram
{
    public static class Class29
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class29!");

            const string fileName = "TextFile29.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class30.Test();
        }
    }
}
