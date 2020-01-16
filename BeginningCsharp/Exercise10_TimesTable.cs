using CBTools_Core.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeginningCsharp {
    class Exercise10_TimesTable {
        public static void Run() {
            int num = ConsoleRead.ReadInt32();
            for (int i = 1; i < 10; i++) {
                Console.WriteLine($"{i} times {num} is {i * num}");
            }
        }
    }
}
