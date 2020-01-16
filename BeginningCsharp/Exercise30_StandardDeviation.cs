using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeginningCsharp {
    class Exercise30_StandardDeviation {
        public static void Run() {
            for(string input = Console.ReadLine(); input != "#"; input = Console.ReadLine()) {
                string[] parts = input.Split(' ');
                double[] series = new double[parts.Length];
                for (int i = 0; i < parts.Length; i++) {
                    series[i] = double.Parse(parts[i]);
                }

                Console.WriteLine($"{StdDev(series):f3}");
            }
        }

        private static double StdDev(double[] series) {
            double mean = series.Average();

            double diffSum = 0;
            for (int i = 0; i < series.Length; i++) {
                diffSum += (series[i] - mean) * (series[i] - mean);
            }

            double diffMean = diffSum / (series.Length - 1);

            double sqrt = Math.Sqrt(diffMean);

            return sqrt;
        }
    }
}
