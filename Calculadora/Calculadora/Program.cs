using Calculadora;
using System.Threading.Channels;

namespace Calculadora {
    class Contas {
        static void Main(string[] args) {

            int s1 = Contas.Sum(2, 3);
            int s2 = Contas.Sum(2, 4, 3);

            Console.WriteLine(s1);
            Console.WriteLine(s2);

        }
    }
}
