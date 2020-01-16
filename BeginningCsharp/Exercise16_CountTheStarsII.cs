using System;
using System.Collections.Generic;
using System.Text;

namespace BeginningCsharp {
    class Exercise16_CountTheStarsII {
        public static void Run() {
            for (string input = Console.ReadLine(); input != "#"; input = Console.ReadLine()) {
                int stars = 0;
                for (int i = 0; i < input.Length; i++) {
                    if (input[i] == '*')
                        stars++;
                    else if (input[i] == '!')
                        break;
                }
                Console.WriteLine(stars);
            }
        }
    }
}
