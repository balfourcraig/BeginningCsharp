using System;
using System.Collections.Generic;
using System.Text;
using CBTools_Core.IO;

namespace BeginningCsharp {
    class Exercise03_Shopping {
        public static void Run() {
            Console.WriteLine("Enter item name");
            string itemName = Console.ReadLine();
            Console.WriteLine("Enter item price");
            double itemPrice = ConsoleRead.ReadDouble();
            Console.WriteLine("Enter quantity");
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
