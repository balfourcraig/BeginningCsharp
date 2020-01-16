using CBTools_Core.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeginningCsharp {
    class Exercise28_SortNamesII {
        public static void Run() {
            var names = new List<string>();
            while(ConsoleRead.ReadIfNotFlag(out string input)) {
                names.Add(input);
            }
            foreach (string n in names.OrderBy(x => x)) {
                Console.WriteLine(n);
            }
        }
    }
}
