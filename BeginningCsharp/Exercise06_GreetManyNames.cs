using CBTools_Core.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeginningCsharp {
    class Exercise6_GreetManyNames {
        public static void Run() {
            for (string input = Console.ReadLine(); input != "#"; input = Console.ReadLine()) {
                Console.WriteLine($"Hello {input}");
            }
        }

        public static void RunWithCBTools() {
            while(ConsoleRead.ReadIfNotFlag(out string input)) {
                Console.WriteLine($"Hello {input}");
            }
        }

        public static void RunWithWhile() {
            string input = Console.ReadLine();
            while(input != "#") {
                Console.WriteLine($"Hello {input}");
                input = Console.ReadLine();
            }            
        }

        public static void RunOneLiner() {
            for (string input = Console.ReadLine(); input != "#"; input = Console.ReadLine(), Console.WriteLine($"Hello {input}")) ;//This is not good code! It's just interesting
        }
    }
}
