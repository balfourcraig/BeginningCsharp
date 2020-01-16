using CBTools_Core.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeginningCsharp {
    class Exercise27_SortNumbers {
        //This exercise can be a really cool one to try without Linq or using any sorting libraries, and try to sort your own array.
        //It's a really deep rabbit hole! But a great learning opportunity. Sorting an array in a naive (slow) way is within your abilty by this point, and if you're interested, you can follow sorting algorithms a long way!
        public static void Run() {
            var nums = new List<int>();
            for(int n = ConsoleRead.ReadInt32(); n != -1; n = ConsoleRead.ReadInt32()) {
                nums.Add(n);
            }
            foreach(int n in nums.OrderBy(x => x))
                Console.WriteLine(n);
        }
    }
}
