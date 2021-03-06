﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BeginningCsharp {
    class Exercise20_SumsOfLinesOfValidNumbers {//Exactly the same as 19, because I had the check there too
        public static void Run() {
            for (string input = Console.ReadLine(); input != "#"; input = Console.ReadLine()) {
                string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int sum = 0;
                for (int i = 0; i < parts.Length; i++) {
                    if (int.TryParse(parts[i], out int num)) {
                        sum += num;
                    }
                    else {
                        Console.WriteLine($"Item {parts[i]} is not an integer. Skipping");
                        continue;
                    }
                }
                Console.WriteLine(sum);
            }
        }
    }
}
