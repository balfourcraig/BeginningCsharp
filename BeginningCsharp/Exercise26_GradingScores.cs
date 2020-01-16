using CBTools_Core.IO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BeginningCsharp {
    class Exercise26_GradingScores {
        public static void Run() {
            var scores = new List<double>();
            for(double s = ConsoleRead.ReadDouble(); s != -1; s = ConsoleRead.ReadDouble()) {
                scores.Add(s);
            }
            double avg = scores.Average();
            double threshold = 0.0001;//This is to avoid floating point errors
            for (int i = 0; i < scores.Count; i++) {
                if(scores[i] - threshold > avg)
                    Console.WriteLine($"{scores[i]:f2} ABOVE AVERAGE");
                else if (scores[i] + threshold < avg)
                    Console.WriteLine($"{scores[i]:f2} BELOW AVERAGE");
                else
                    Console.WriteLine($"{scores[i]:f2} AVERAGE");
            }
        }

        public static void Run_Fancy() {
            var scores = new List<double>();
            for (double s = ConsoleRead.ReadDouble(); s != -1; s = ConsoleRead.ReadDouble()) {
                scores.Add(s);
            }
            double avg = scores.Average();
            double threshold = 0.0001;
            for (int i = 0; i < scores.Count; i++) {

                string pos = "";
                var color = ConsoleColor.Yellow;

                if (scores[i] - threshold > avg) {
                    pos = "ABOVE ";
                    color = ConsoleColor.Green;
                }
                else if (scores[i] + threshold < avg) {
                    pos = "BELOW ";
                    color = ConsoleColor.Red;
                }

                ConsoleWrite.WriteLinesColored(color, $"{scores[i]:f2} {pos}AVERAGE");
            }
        }
    }
}
