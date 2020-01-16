using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeginningCsharp {
    class Exercise24_Median {
        public static void Run() {
            for (string input = Console.ReadLine(); input != "#"; input = Console.ReadLine()) {
                int[] nums = ParseArray(input.Split(' ', StringSplitOptions.RemoveEmptyEntries));
                int[] sorted = nums.Skip(1).OrderBy(x => x).ToArray();

                double med = sorted.Length % 2 == 0 
                    ? (sorted[sorted.Length / 2] + sorted[sorted.Length / 2 + 1]) / 2.0 
                    : sorted[sorted.Length / 2 + 1];

                Console.WriteLine($"{med:f2}");
            }
        }

        private static int[] ParseArray(string[] arr) {
            int[] nums = new int[arr.Length];
            for (int i = 1; i < arr.Length; i++) {
                if (int.TryParse(arr[i], out int n))
                    nums[i-1] = n;
                else
                    Console.WriteLine($"{arr[i]} could ");
            }
            return nums;
        }
    }
}
