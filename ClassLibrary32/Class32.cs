using System;
using System.IO;

namespace TestProgram
{
    public static class Class32
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class32!");

            const string fileName = "TextFile32.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class33.Test();
        }
    }
}
