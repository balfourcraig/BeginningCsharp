using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CBTools_Core.IO;

namespace BeginningCsharp {
    class Exercise25_SortNamesI {
        public static void Run() {
            int numNames = ConsoleRead.ReadInt32();
            var names = new List<string>(numNames);
            for (int i = 0; i < numNames; i++) {
                names.Add(Console.ReadLine());
            }
            foreach(string n in names.OrderBy(x => x)) {
                Console.WriteLine(n);
            }
        }
    }
}
