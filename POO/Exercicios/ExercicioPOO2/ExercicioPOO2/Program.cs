using System;

namespace ExercicioPOO2 {
    class Program {
        static void Main(string[] args) {
            Salario x, y;
            x = new Salario();
            y = new Salario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            x.Nome = Console.ReadLine();    
            x.SalarioValor = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados do segundo funcionário: ");
            y.Nome = Console.ReadLine();
            y.SalarioValor = double.Parse(Console.ReadLine());
            double media = (x.SalarioValor + y.SalarioValor) / 2;
            Console.WriteLine($"Salário médio : {media}");
        }
    }
}