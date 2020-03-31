﻿using System;
using System.IO;

namespace TestProgram
{
    public static class Class4
    {
        public static void Test()
        {
            Console.WriteLine("Hello from Class4!");

            const string fileName = "TextFile4.txt";
            if (File.Exists(fileName))
            { Console.WriteLine(File.ReadAllText(fileName)); }
            else
            { Console.Error.WriteLine(fileName + " does not exist!"); }

            Class5.Test();
        }
    }
}