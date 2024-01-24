using System;
using System.Globalization;

namespace TerceiroExercicio
{
    internal class Program {
        static void Main(string[] args) {


            retangulo retangulo = new retangulo();

            
            Console.WriteLine("Digite a largura e altura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = retangulo.CalcularArea();
            double perimetro = retangulo.CalcularPerimetro();
            double diagonal = retangulo.CalcularDiagonal();
           
            
            Console.WriteLine("ÁREA : " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO : " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIANONÁL : " + diagonal.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
