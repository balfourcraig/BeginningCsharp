using CBTools_Core.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeginningCsharp {
    class Exercise8_PassFailMerit {
        public static void Run() {
            for (int i = ConsoleRead.ReadInt32(); i != -1; i = ConsoleRead.ReadInt32()) {
                if (i < 50)
                    Console.WriteLine("FAIL");
                else if (i < 80)
                    Console.WriteLine("PASS");
                else
                    Console.WriteLine("MERIT");
            }
        }
    }
}
