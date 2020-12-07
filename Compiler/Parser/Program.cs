using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Compiler
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string text = File.ReadAllText("program.txt");
            foreach (var token in Compiler.TokensOut(text))
            {
                Console.WriteLine(token);
            }
        }
    }
}