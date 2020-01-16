using System;
using System.Collections.Generic;
using System.Text;

namespace BeginningCsharp {
    class Exercise12_WordCount {
        public static void Run() {//This is a very, very naive approach and will only work on perfect input
            for (string input = Console.ReadLine(); input != "#"; input = Console.ReadLine()) {
                if (string.IsNullOrWhiteSpace(input)) {
                    Console.WriteLine(0);
                }
                else {
                    int spaces = 1;
                    for (int i = 0; i < input.Length; i++) {
                        if (input[i] == ' ')
                            spaces++;
                    }
                    Console.WriteLine(spaces);
                }
            }
        }

        public static void RunWithSplit() {//This one is a lot more accurate
            for (string input = Console.ReadLine(); input != "#"; input = Console.ReadLine()) {
                Console.WriteLine(input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length);
            }
        }
    }
}
