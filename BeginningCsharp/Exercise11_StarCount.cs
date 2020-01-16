using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeginningCsharp {
    class Exercise11_StarCount {
        public static void Run() {
            for(string input = Console.ReadLine(); input != "#"; input = Console.ReadLine()) {
                int stars = 0;
                for (int i = 0; i < input.Length; i++) {
                    if (input[i] == '*')
                        stars++;
                }
                Console.WriteLine(stars);
            }
        }

        public static void RunLINQ() {
            for (string input = Console.ReadLine(); input != "#"; input = Console.ReadLine()) {
                Console.WriteLine(input.Count(x => x == '*'));//This is lambda syntax, and you can safely ignore it for now. Just showing more LINQ coolness
            }
        }

        public static void RunCounterMethod() {
            for (string input = Console.ReadLine(); input != "#"; input = Console.ReadLine()) {
                Console.WriteLine(CountStars(input));//Call our own star counting method
            }
        }

        static int CountStars(string input) {//Count stars in a string and return the result
            int stars = 0;
            for (int i = 0; i < input.Length; i++) {
                if (input[i] == '*')
                    stars++;
            }
            return stars;
        }
    }
}
