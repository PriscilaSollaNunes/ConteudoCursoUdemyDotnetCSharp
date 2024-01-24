using System;

namespace PrimeiroExercicio {
    internal class Program {
        static void Main(string[] args) {

            Idade pessoa1, pessoa2;

            pessoa1 = new Idade();
            pessoa2 = new Idade();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome:"); pessoa1.nome = (Console.ReadLine());
            Console.Write("Idade: "); pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome:"); pessoa2.nome = (Console.ReadLine());
            Console.Write("Idade: "); pessoa2.idade = int.Parse(Console.ReadLine());



            if (pessoa1.idade > pessoa2.idade) {
                Console.WriteLine("Pessoa mais velha:" + pessoa1.nome);
            }
            else {
                Console.WriteLine("Pessoa mais velha:" + pessoa2.nome);
            }
        }
    }
}