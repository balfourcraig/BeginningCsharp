using CBTools_Core.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeginningCsharp {
    class Exercise06_GreetManyNames {
        public static void Run() {
            for (string input = Console.ReadLine(); input != "#"; input = Console.ReadLine()) {
                Console.WriteLine($"Hello {input}");
            }
        }

        public static void Run_CBTools() {
            while(ConsoleRead.ReadIfNotFlag(out string input)) {
                Console.WriteLine($"Hello {input}");
            }
        }

        public static void Run_While() {
            string input = Console.ReadLine();
            while(input != "#") {
                Console.WriteLine($"Hello {input}");
                input = Console.ReadLine();
            }            
        }

        public static void Run_OneLiner() {
            for (string input = Console.ReadLine(); input != "#"; input = Console.ReadLine(), Console.WriteLine($"Hello {input}")) ;//This is not good code! It's just interesting
        }
    }
}
