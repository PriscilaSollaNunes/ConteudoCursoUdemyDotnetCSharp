using System;
using System.Globalization;

namespace SegundoExercicio {
    internal class Program {
        static void Main(string[] args) {


            Funcionario pessoa1, pessoa2;

            pessoa1 = new Funcionario();
            pessoa2 = new Funcionario();

            Console.WriteLine("Dados da primeiro funcionário: ");
            Console.Write("Nome: "); pessoa1.nome = (Console.ReadLine());
            Console.Write("Salário: "); pessoa1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: "); pessoa2.nome = (Console.ReadLine());
            Console.Write("Salário: "); pessoa2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (pessoa1.salario + pessoa2.salario) / 2;

            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
