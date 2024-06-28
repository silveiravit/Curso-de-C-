using System;

namespace ExercicioCondicional1 {
    class Program {
        static void Main(string[] args) { 
        
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("====================");
            if (n >= 0) {
                Console.WriteLine($"O valor {n} é positivo.");
            }
            else {
                Console.WriteLine($"O valor {n} é negativo.");
            }

        }
    }
}