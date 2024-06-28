using System;

namespace ExercicioWhile1 {
    class Program {
        static void Main(string[] args) {

            int senha = 0;
            int senhaCorreta = 2002;

            while ( senha != senhaCorreta ) {
                senha++;
                if (senha != senhaCorreta) {
                    Console.WriteLine($"Acesso negado! senha:{senha}");
                }
                else {
                    Console.WriteLine($"Acesso permitido! {senha}");
                }
            }
        }
    }
}