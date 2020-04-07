using System;
using System.IO;

namespace TestProgram
{
    public static class Class30
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class30!");

            const string fileName = "TextFile30.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            //Class31.Test();
        }
    }
}
