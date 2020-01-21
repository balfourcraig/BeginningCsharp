using CBTools_Core.IO;
using System;

namespace BeginningCsharp {
    class Exercise {
        public (string name, Action method)[] actions;
        public string name;
        public int number;

        public Exercise(string name, int number, params (string, Action)[] actions) {
            this.actions = actions;
            this.name = name;
            this.number = number;
        }

        public Exercise(string name, int number, Action action) {
            this.actions = new (string, Action)[] { ("DEFAULT", action) };
            this.name = name;
            this.number = number;
        }

        public void Run() {
            do {
                Console.Clear();
                Console.WriteLine(name);
                if (actions.Length == 1) {
                    actions[0].method();
                }
                else {
                    Console.WriteLine("Which action? (enter number)");
                    for (int i = 0; i < actions.Length; i++) {
                        Console.WriteLine($"{i} {actions[i].name}");
                    }
                    //int actionNum = ConsoleRead.ReadInt32(actions.Length - 1);

                    ConsoleKeyInfo info = Console.ReadKey();
                    while(info.Key == ConsoleKey.Escape || info.KeyChar < '0' || info.KeyChar > ('9' - actions.Length)) {
                        if (info.Key == ConsoleKey.Escape) {
                            goto end;//Do not do this! This whole method needs work, but this is the worst line
                        }
                        Console.WriteLine("Not a valid number");
                        info = Console.ReadKey();
                    }
                    int actionNum = info.KeyChar - '0';//cryptic

                    Console.Clear();
                    Console.WriteLine($"Running {actions[actionNum].name}");
                    actions[actionNum].method();
                }
                //Console.Clear();
                ConsoleWrite.CharLine();
                Console.WriteLine($"Press Esc to go back, any other key to continue with {name}");
            } while(Console.ReadKey().Key != ConsoleKey.Escape);
            end:;
        }
    }

    class Program {
        //This is not a very nice was of listing them all, but it works
        static readonly Exercise[] exercises = {
            new Exercise("Greet", 1, Exercise01_Greet.Run),
            new Exercise("Basic Maths", 2, Exercise02_BasicMaths.Run),
            new Exercise("Shopping", 3, 
                ("Default", Exercise03_Shopping.Run),
                ("No CBTools", Exercise03_Shopping.Run_NoCBTools)),
            new Exercise("Formal Names", 4, 
                ("Default", Exercise04_FormalNames.Run),
                ("Split", Exercise04_FormalNames.Run_Split)),
            new Exercise("Discount", 5, Exercise05_Discount.Run),
            new Exercise("Greet Many Names", 6, 
                ("Default",Exercise06_GreetManyNames.Run),
                ("CBTools",Exercise06_GreetManyNames.Run_CBTools),
                ("One-Liner",Exercise06_GreetManyNames.Run_OneLiner),
                ("While",Exercise06_GreetManyNames.Run_While)),
            new Exercise("Pass-Fail", 7, Exercise07_PassFail.Run),
            new Exercise("Pass-Fail-Merit", 8, Exercise08_PassFailMerit.Run),
            new Exercise("Sum and Average", 9, 
                ("Default", Exercise09_SumAndAverage.Run),
                ("LINQ", Exercise09_SumAndAverage.Run_LINQ)),
            new Exercise("Times Table", 10, Exercise10_TimesTable.Run),
            new Exercise("Star Count", 11, 
                ("Default", Exercise11_StarCount.Run),
                ("Counter Method", Exercise11_StarCount.Run_CounterMethod),
                ("LINQ", Exercise11_StarCount.Run_LINQ)),
            new Exercise("Word Count", 12, 
                ("Default", Exercise12_WordCount.Run),
                ("Split", Exercise12_WordCount.Run_Split)),
            new Exercise("Reverse a String", 13, 
                ("Default", Exercise13_ReverseAString.Run),
                ("Fast", Exercise13_ReverseAString.Run_Fast),
                ("LINQ", Exercise13_ReverseAString.Run_LINQ),
                ("Create", Exercise13_ReverseAString.Run_Create)),
            new Exercise("How Many Vowels", 14, 
                ("Default", Exercise14_HowManyVowels.Run),
                ("LINQ", Exercise14_HowManyVowels.Run_LINQ)),
            new Exercise("Vowel Count", 15, 
                ("Default", Exercise15_VowelCount.Run),
                ("Arrays", Exercise15_VowelCount.Run_Arrays)),
            new Exercise("Count The Stars II", 16, Exercise16_CountTheStarsII.Run),
            new Exercise("Test Scores", 17, Exercise17_TestScores.Run),
            new Exercise("Largest Score", 18, Exercise18_LargestScore.Run),
            new Exercise("Sums of Lines of Numbers", 19, Exercise19_SumsOfLinesOfNumbers.Run),
            new Exercise("Sums of Lines of Valid Numbers", 20, Exercise20_SumsOfLinesOfValidNumbers.Run),
            new Exercise("Test Scores", 21, Exercise21_TestScores.Run),
            new Exercise("Chess Games", 22, 
                ("Default", Exercise22_ChessGames.Run),
                ("LINQ", Exercise22_ChessGames.Run_LINQ)),
            new Exercise("Min and Max Numbers", 23, 
                ("Default", Exercise23_MinAndMaxNumbers.Run),
                ("LINQ", Exercise23_MinAndMaxNumbers.Run_LINQ)),
            new Exercise("Median", 24, Exercise24_Median.Run),
            new Exercise("Sort Names I", 25, Exercise25_SortNamesI.Run),
            new Exercise("Grading Scores", 26, 
                ("Default", Exercise26_GradingScores.Run),
                ("Fancy", Exercise26_GradingScores.Run_Fancy)),
            new Exercise("Sort Numbers", 27, Exercise27_SortNumbers.Run),
            new Exercise("Sort Names II", 28, Exercise28_SortNamesII.Run),
            new Exercise("Standard Deviation", 30, Exercise30_StandardDeviation.Run),
            new Exercise("Morse Code Generator", 35, Exercise35_MorseCodeGenerator.Run),
            new Exercise("CSV Files", 40, 
                ("Default", Exercise40_CSVFiles.Run),
                ("Simple", Exercise40_CSVFiles.Run_Simple)),
            new Exercise("Extra - Decode Decode", 99, ExerciseExtra_DecodeDecode.Run)
        };

        static void Main() {//This is really messy
            while(true) {//Should probably be able to exit somehow
                Console.Clear();
                Console.WriteLine("Enter number of exercise:");
                foreach(Exercise e in exercises) {
                    Console.WriteLine(e.number + "\t" + e.name);
                }

                int num = ConsoleRead.ReadInt32();
                Exercise picked = null;
                foreach (Exercise e in exercises) {
                    if(e.number == num) {
                        picked = e;
                        break;
                    }
                }
                if(picked == null) {
                    Console.WriteLine("Not a valid exercise number. Start again");
                    Console.WriteLine("Press any key to start again");
                    Console.ReadKey();
                    continue;
                }
                picked.Run();
                //Console.Clear();
                //if (picked.actions.Length == 1) {
                //    Console.WriteLine($"Running {picked.name}");
                //    picked.actions[0].method();
                //}
                //else {
                //    Console.WriteLine("Which action? (enter number)");

                //    for (int i = 0; i < picked.actions.Length; i++) {
                //        Console.WriteLine($"{i} {picked.actions[i].name}");
                //    }

                //    int actionNum = ConsoleRead.ReadInt32(picked.actions.Length-1);

                //    Console.Clear();
                //    Console.WriteLine($"Running {picked.actions[actionNum].name}");
                //    picked.actions[actionNum].method();
                //}

                //Console.WriteLine("Press any key to continue");
                //Console.ReadKey();
            }
        }
    }
}
