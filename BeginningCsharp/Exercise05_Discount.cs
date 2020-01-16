using CBTools_Core.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeginningCsharp {
    class Exercise05_Discount {
        public static void Run() {
            string itemName = Console.ReadLine();
            double itemPrice = ConsoleRead.ReadDouble();
            int quant = ConsoleRead.ReadInt32();

            Console.WriteLine($"{quant} x {itemName} @ {itemPrice:c2}");
            if (quant < 10) {
                Console.WriteLine($"Total: { itemPrice* quant:c2}");
            }
            else {
                Console.WriteLine($"Subtotal: { itemPrice * quant:c2}");
                Console.WriteLine($"-10% Discount: {itemPrice * quant * 0.1:c2}");//Yes, you can store this in a variable and subtract it in the next step, but there's not really any need
                Console.WriteLine($"Total: { itemPrice * quant * 0.9:c2}");
            }
            
        }
    }
}
