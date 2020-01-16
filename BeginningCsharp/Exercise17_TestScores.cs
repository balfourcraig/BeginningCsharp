using System;
using System.Collections.Generic;
using System.Text;

namespace BeginningCsharp {
    class Exercise17_TestScores {
        public static void Run() {//For the sake of the exercise, you don't need the checks, but it's good practise
            for (string input = Console.ReadLine(); input != "#"; input = Console.ReadLine()) {
                string[] parts = input.Split(',');
                if(parts.Length != 6) {
                    Console.WriteLine("Incorrect format. Try again");
                    continue;
                }
                else {
                    if(
                        int.TryParse(parts[2], out int score1) &&
                        int.TryParse(parts[3], out int score2) &&
                        int.TryParse(parts[4], out int score3) &&
                        int.TryParse(parts[5], out int score4)
                        ) {
                        string surname = parts[1];
                        string firstname = parts[0];

                        int total = score1 + score2 + score3 + score4;

                        Console.WriteLine($"{firstname} {surname} {total}");
                    }
                    else {
                        Console.WriteLine("Incorrect format. Try again");
                        continue;
                    }
                }
            }
        }
    }
}
