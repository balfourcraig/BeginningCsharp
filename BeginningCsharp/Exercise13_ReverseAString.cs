using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeginningCsharp {
    class Exercise13_ReverseAString {
        public static void Run() {
            for (string input = Console.ReadLine(); input != "#"; input = Console.ReadLine()) {
                string backwards = string.Empty;
                for (int i = input.Length - 1; i >= 0; i--) {
                    backwards += input[i];
                }
                Console.WriteLine(new string(backwards));
            }
        }

        public static void Run_Fast() {
            for (string input = Console.ReadLine(); input != "#"; input = Console.ReadLine()) {
                char[] letters = new char[input.Length];
                for (int i = 0; i < input.Length; i++) {
                    letters[letters.Length - 1 - i] = input[i];
                }
                Console.WriteLine(new string(letters));
            }
        }

        public static void Run_LINQ() {
            for (string input = Console.ReadLine(); input != "#"; input = Console.ReadLine()) {
                Console.WriteLine(new string(input.Reverse().ToArray()));//This is a bit messy really
            }
        }
    }
}
