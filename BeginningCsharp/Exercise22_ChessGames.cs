using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BeginningCsharp {
    class Exercise22_ChessGames {
        public static void Run() {
            for (string input = Console.ReadLine(); input != "#"; input = Console.ReadLine()) {
                input = input.ToUpperInvariant();
                int a = 0, b = 0;

                for (int i = 0; i < input.Length; i++) {
                    switch (input[i]) {
                        case 'A':
                            a++;
                            break;
                        case 'B':
                            b++;
                            break;
                        default:
                            Console.WriteLine($"Oh no! Unknown player {input[i]}");
                            break;
                    }
                }
                Console.WriteLine($"A {a} B {b}");
            }
        }
        public static void RunLINQ() {
            for (string input = Console.ReadLine(); input != "#"; input = Console.ReadLine()) {
                input = input.ToUpperInvariant();

                int a = input.Count(x => x == 'A');
                int b = input.Count(x => x == 'B');

                Console.WriteLine($"A {a} B {b}");
            }
        }
    }
}
