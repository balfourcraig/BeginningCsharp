using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BeginningCsharp {
    class Exercise35_MorseCodeGenerator {

        private static Dictionary<char,string> GetMapping(string path) {
            string[] lines = File.ReadAllLines(path);
            var lookup = new Dictionary<char, string>(lines.Length);
            foreach (string s in lines) {
                string[] parts = s.Split(' ');
                lookup.Add(parts[0][0], parts[1]);//This has no checking, not very good. Will crash if unexpected input
            }
            return lookup;
        }

        public static void Run() {
            string path = @"data\morse.txt";
            Dictionary<char, string> lookup = GetMapping(path);

            for (string input = Console.ReadLine(); input != "#"; input = Console.ReadLine()) {
                string output = "";
                input = input.ToUpperInvariant();
                for (int i = 0; i < input.Length; i++) {
                    if (lookup.TryGetValue(input[i], out string val))
                        output += val;
                    else if (input[i] == ' ')
                        output += " ";
                    else
                        output += "?";

                    output += " ";
                }
                Console.WriteLine(output);
            }
        }
    }
}
