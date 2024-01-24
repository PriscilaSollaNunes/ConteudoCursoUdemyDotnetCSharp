using System;
using System.Globalization;

namespace QuintoExercicio
{
    internal class Program {
        static void Main(string[] args) {

            Notas nota = new Notas();

            Console.Write("Nome do aluno: ");
            nota.Nome = Console.ReadLine();
            Console.WriteLine("Digite 3 três notas do aluno: ");
            nota.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            nota.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = "
 + nota.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (nota.Aprovado()) {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                + nota.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                + " PONTOS");
            }

        }
    }
}
