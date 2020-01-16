using System;
using System.Collections.Generic;
using System.Text;

namespace BeginningCsharp {
    class Exercise15_VowelCount {
        private static readonly char[] vowels = { 'A', 'E', 'I', 'O', 'U' };

        public static void Run() {//This shows how the naive approach can become ugly quite quickly
            for (string input = Console.ReadLine().ToUpperInvariant(); input != "#"; input = Console.ReadLine().ToUpperInvariant()) {
                int aCount = 0, eCount = 0, iCount = 0, oCount = 0, uCount = 0;

                for (int i = 0; i < input.Length; i++) {
                    if (input[i] == 'A')
                        aCount++;
                    else if (input[i] == 'E')
                        eCount++;
                    else if (input[i] == 'I')
                        iCount++;
                    else if (input[i] == 'O')
                        oCount++;
                    else if (input[i] == 'U')
                        uCount++;
                }
                Console.WriteLine($"a:{aCount},e:{eCount},i:{iCount},o:{oCount},u:{uCount}");
            }
        }

        public static void RunWithArrays() {//This approach is not much better tbh, but it's a little easier to add new letters to
            for (string input = Console.ReadLine().ToUpperInvariant(); input != "#"; input = Console.ReadLine().ToUpperInvariant()) {
                int[] counts = new int[vowels.Length];
                for (int i = 0; i < input.Length; i++) {
                    for (int v = 0; v < vowels.Length; v++) {
                        if(input[i] == vowels[v]) {
                            counts[v]++;
                            break;
                        }
                    }
                }
                string output = "";
                for (int i = 0; i < vowels.Length; i++) {
                    output += $"{vowels[i]}:{counts[i]}";
                    if (i < vowels.Length - 1)
                        output += ",";
                }
                Console.WriteLine(output);
            }
        }
    }
}
