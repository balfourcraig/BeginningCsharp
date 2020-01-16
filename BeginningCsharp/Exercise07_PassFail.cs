using CBTools_Core.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeginningCsharp {
    class Exercise7_PassFail {
        public static void Run() {
            for (int i = ConsoleRead.ReadInt32(); i != -1; i = ConsoleRead.ReadInt32()) {
                if (i < 50)
                    Console.WriteLine("FAIL");
                else
                    Console.WriteLine("PASS");
            }
        }
    }
}
