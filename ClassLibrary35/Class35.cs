using System;
using System.IO;

namespace TestProgram
{
    public static class Class35
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class35!");

            const string fileName = "TextFile35.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            //Class36.Test();
        }
    }
}
