using System;
using System.IO;

namespace TestProgram
{
    public static class Class13
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class13!");

            const string fileName = "TextFile13.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class14.Test();
        }
    }
}