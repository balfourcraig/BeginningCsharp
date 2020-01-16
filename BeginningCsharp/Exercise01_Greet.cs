using System;
using System.Collections.Generic;
using System.Text;

namespace BeginningCsharp {
    class Exercise01_Greet {
        public static void Run() {
            Console.WriteLine("Enter surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter first name");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter city");
            string city = Console.ReadLine();

            Console.WriteLine($"Hello {firstname} {surname} of {city}");
        }
    }
}
