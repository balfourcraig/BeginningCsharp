using CBTools_Core.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeginningCsharp {
    class Exercise09_SumAndAverage {
        public static void Run() {
            int count = 0;
            int sum = 0;
            for (int i = ConsoleRead.ReadInt32(); i != -1; i = ConsoleRead.ReadInt32()) {
                sum += i;
                count++;
            }
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {sum/(double)count:f2}");
        }

        public static void Run_LINQ() {//This one is not as good as the above running total, but it does show how cool LINQ can be
            var nums = new List<int>();
            for (int i = ConsoleRead.ReadInt32(); i != -1; i = ConsoleRead.ReadInt32()) {
                nums.Add(i);
            }
            Console.WriteLine($"Sum: {nums.Sum()}");
            Console.WriteLine($"Average: {nums.Average():f2}");
        }
    }
}
