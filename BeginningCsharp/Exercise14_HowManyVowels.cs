using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeginningCsharp {
    class Exercise14_HowManyVowels {
        private static readonly char[] vowels = { 'A', 'E', 'I', 'O', 'U' };

        public static void Run() {
            for (string input = Console.ReadLine().ToUpperInvariant(); input != "#"; input = Console.ReadLine().ToUpperInvariant()) {
                int vowels = 0;
                for (int i = 0; i < input.Length; i++) {
                    if (input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U')
                        vowels++;
                }
                Console.WriteLine(vowels);
            }
        }

        public static void Run_LINQ() {
            for (string input = Console.ReadLine().ToUpperInvariant(); input != "#"; input = Console.ReadLine().ToUpperInvariant()) {
                Console.WriteLine(input.Count(x => vowels.Contains(x)));
            }
        }
    }
}
