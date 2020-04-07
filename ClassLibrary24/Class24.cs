using System;
using System.IO;

namespace TestProgram
{
    public static class Class24
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class24!");

            const string fileName = "TextFile24.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class25.Test();
        }
    }
}
