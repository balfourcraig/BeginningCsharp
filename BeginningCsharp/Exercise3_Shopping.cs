using System;
using System.Collections.Generic;
using System.Text;
using CBTools_Core.IO;

namespace BeginningCsharp {
    class Exercise3_Shopping {
        public static void Run() {
            string itemName = Console.ReadLine();
            double itemPrice = ConsoleRead.ReadDouble();
            int quant = ConsoleRead.ReadInt32();

            Console.WriteLine($"{quant} x {itemName} @ {itemPrice:c2} Total: {itemPrice * quant:c2}");
        }

        public static void Run_NoCBTools() {
            string itemName = Console.ReadLine();
            //These parse methods will throw if the input cannot be parsed. In practise, best to always use TryParse
            double itemPrice = double.Parse(Console.ReadLine());            
            int quant = int.Parse(Console.ReadLine());

            Console.WriteLine($"{quant} x {itemName} @ {itemPrice:c2} Total: {itemPrice * quant:c2}");
        }
    }
}
