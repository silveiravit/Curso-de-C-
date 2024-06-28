using System;

namespace ExercicioCondional2 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0) {
                Console.WriteLine($"O valor {n} é par.");
            }
            else {
                Console.WriteLine($"O valor {n} é ímpar.");
            }

        }
    }
}