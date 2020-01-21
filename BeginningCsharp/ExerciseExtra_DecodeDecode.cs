using System;
using System.Collections.Generic;
using System.Text;

namespace BeginningCsharp {
    class ExerciseExtra_DecodeDecode {
        public static void Run() {
            for (string input = Console.ReadLine(); input != "#"; input = Console.ReadLine()) {
                int shift = int.Parse(input.Substring(0, input.IndexOf(' ')));
                string output = ""; //could use a fixed array here for speed, but not really worth it
                for (int i = input.IndexOf(' ') + 1; i < input.Length; i++) {
                    output += Cypher(input[i], shift);
                }
                Console.WriteLine(output);
            }
        }

        private static char Cypher(char c, int shift) {
            if (c > 'A' && c < 'Z')
                return (char)(FullMod(c - 'A' + shift, 'Z' - 'A') + 'A');
            else if (c > 'a' && c < 'z')
                return (char)(FullMod(c - 'a' + shift, 'z' - 'a') + 'a');
            else
                return c;                 
        }

        /// <summary>
        /// Modulus which respects negative numbers. Significantly slower than standard %
        /// </summary>
        /// <param name="lhs">Left hand side</param>
        /// <param name="rhs">Right hand side</param>
        /// <returns></returns>
        private static int FullMod(int lhs, int rhs) => (lhs % rhs + rhs) % rhs;
    }
}
