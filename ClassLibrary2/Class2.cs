using System;
using System.IO;

namespace TestProgram
{
    public static class Class2
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class2!");

            const string fileName = "TextFile2.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class3.Test();
        }
    }
}
