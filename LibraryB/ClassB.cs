using System;
using System.IO;

namespace LibraryB
{
    public static class ClassB
    {
        public static void Test()
        {
            Console.WriteLine("Hello from ClassB!");

            const string fileName = "TextFileB.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }
        }
    }
}
