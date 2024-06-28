using System;

namespace ExercicioCondicional4 {
    class Program {
        static void Main(string[] args) { 
            
            int horaInicial = int.Parse(Console.ReadLine());
            int horaFinal = int.Parse(Console.ReadLine());

            if (horaInicial > horaFinal) {
                int somaHora = (24 - horaInicial) + horaFinal;
                Console.WriteLine($"O jogo durou {somaHora} horas(s)");
            }
            else {
                int somaHora = horaFinal - horaInicial;
                Console.WriteLine($"O jogo durou {somaHora} horas(s)");
            }
        } 
    }
}