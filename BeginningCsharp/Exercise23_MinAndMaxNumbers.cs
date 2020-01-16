using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BeginningCsharp {
    class Exercise23_MinAndMaxNumbers {
        public static void Run() {
            for (string input = Console.ReadLine(); input != "#"; input = Console.ReadLine()) {
                int[] nums = ParseArray(input.Split(' ', StringSplitOptions.RemoveEmptyEntries));
                int max = int.MinValue;
                int min = int.MaxValue;

                for (int i = 0; i < nums.Length; i++) {
                    if (nums[i] > max)
                        max = nums[i];
                    if (nums[i] < min)
                        min = nums[i];
                }

                Console.WriteLine($"Min: {min} Max: {max}");
            }
        }

        public static void RunLINQ() {
            for (string input = Console.ReadLine(); input != "#"; input = Console.ReadLine()) {
                int[] nums = ParseArray(input.Split(' ', StringSplitOptions.RemoveEmptyEntries));
                Console.WriteLine($"Min: {nums.Min()} Max: {nums.Max()}");
            }
        }

        private static int[] ParseArray(string[] arr) {
            int[] nums = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++) {
                if(int.TryParse(arr[i], out int n)) 
                    nums[i] = n;
                else 
                    Console.WriteLine($"{arr[i]} could ");
            }
            return nums;
        }
    }
}
