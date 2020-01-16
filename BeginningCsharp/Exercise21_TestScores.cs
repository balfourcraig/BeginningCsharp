using System;
using System.Collections.Generic;
using System.Text;

namespace BeginningCsharp {
    class Exercise21_TestScores {
        public static void Run() {
            for (string input = Console.ReadLine(); input != "#"; input = Console.ReadLine()) {
                string[] parts = input.Split(',', StringSplitOptions.RemoveEmptyEntries);
                
                if(parts.Length < 2) {
                    Console.WriteLine("Incorrect format");
                    continue;
                }
                string surname = parts[0];
                string firstname = parts[1];

                int sum = 0;
                for (int i = 2; i < parts.Length; i++) {
                    if (int.TryParse(parts[i], out int num)) {
                        sum += num;
                    }
                    else {
                        Console.WriteLine($"Item {parts[i]} is not an integer. Skipping");
                        continue;
                    }
                }
                Console.WriteLine($"{firstname} {surname} {sum}");
            }
        }
    }
}
