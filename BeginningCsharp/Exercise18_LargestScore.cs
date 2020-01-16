using System;
using System.Collections.Generic;
using System.Text;

namespace BeginningCsharp {
    class Exercise18_LargestScore {
        public static void Run() {
            for (string input = Console.ReadLine(); input != "#"; input = Console.ReadLine()) {
                string[] parts = input.Split(',');
                if (parts.Length != 4) {
                    Console.WriteLine("Incorrect format. Try again");
                    continue;
                }
                else {
                    if (int.TryParse(parts[1], out int score1) && int.TryParse(parts[3], out int score2)) { 
                        string name1 = parts[0];
                        string name2 = parts[2];

                        if(score1 > score2) 
                            Console.WriteLine($"{name1} {score1} {name2} {score2}");
                        else
                            Console.WriteLine($"{name2} {score2} {name1} {score1}");
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
