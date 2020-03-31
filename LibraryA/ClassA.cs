using System;
using System.IO;
using LibraryB;

namespace LibraryA
{
    public static class ClassA
    {
        public static void Test()
        {
            Console.WriteLine("Hello from ClassA!");

            const string fileName = "TextFileA.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            ClassB.Test();
        }
    }
}
