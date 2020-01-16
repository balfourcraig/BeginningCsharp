using System;
using System.Collections.Generic;
using System.Text;

namespace BeginningCsharp {
    class Exercise4_FormalNames {
        public static void Run() {
            string line = Console.ReadLine();
            int commaIndex = line.IndexOf(',');
            if (commaIndex == -1)
                throw new Exception("Just don't");//Can't be fucked handling this in an exercise

            string surname = line.Substring(0, commaIndex).Trim();
            string firstName = line.Substring(commaIndex + 1).Trim();

            Console.WriteLine($"{firstName} {surname}");
        }

        public static void RunWithSplit() {
            string line = Console.ReadLine();
            string[] parts = line.Split(',');
            if(parts.Length != 2)
                throw new Exception("Just don't");//Can't be fucked handling this in an exercise

            string surname = parts[0].Trim();
            string firstName = parts[1].Trim();

            Console.WriteLine($"{firstName} {surname}");
        }
    }
}
