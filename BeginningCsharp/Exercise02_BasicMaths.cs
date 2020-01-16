using CBTools_Core.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeginningCsharp {
    class Exercise02_BasicMaths {
        public static void Run() {
            Console.WriteLine("Enter an integer");
            int num1 = ConsoleRead.ReadInt32();
            Console.WriteLine("Enter another integer");
            int num2 = ConsoleRead.ReadInt32();

            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
        }
    }
}
