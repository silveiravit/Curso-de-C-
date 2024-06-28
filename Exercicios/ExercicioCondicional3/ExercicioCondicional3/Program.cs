using System;

namespace ExercicioCondicional3 {
    class Program {
        static void Main(string[] args) {

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            if (n1 % n2 == 0 || n2 % n1 == 0) {
                Console.WriteLine($"Os números {n1} e {n2} são múltiplos.");
            }
            else {
                Console.WriteLine($"Os números {n1} e {n2} não são múltiplos.");
            }
        }
    }
}