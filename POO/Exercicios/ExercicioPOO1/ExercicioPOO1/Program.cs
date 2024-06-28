using System;

namespace ExercicioPOO1 {
    class Program {
        static void Main(string[] args) {

            MaisVelho x, y;
            x = new MaisVelho();
            y = new MaisVelho();

            Console.WriteLine("Entre com os dados da primeira pessoa: ");
            x.Nome = Console.ReadLine(); 
            x.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com os dados da segunda pessoa: ");
            y.Nome = Console.ReadLine();
            y.Idade = int.Parse(Console.ReadLine());
            if (x.Idade > y.Idade) {
                Console.WriteLine($"Pessoa mais velha: {x.Nome}");
            }
            else {
                Console.WriteLine($"Pessoa mais velha: {y.Nome}");
            }
        }
    }
}