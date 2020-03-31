using System;
using System.IO;

namespace TestProgram
{
    public static class Class3
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class3!");

            const string fileName = "TextFile3.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class4.Test();
        }
    }
}
