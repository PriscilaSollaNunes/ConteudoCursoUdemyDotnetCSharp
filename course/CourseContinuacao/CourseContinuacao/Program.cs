using System;
using System.Globalization;

namespace CourseContinuacao {
    internal class Program {

        static void Main(string[] args) {

            

            
            Console.Write("Qual é a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quant = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = cambio.DolarParaReal(quant, dolar);


            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));




        }

    }
}





// Aula 46

//        static double Pi = 3.14;
//        static void Main(string[] args) {
//            Console.Write("Entre o valor do raio: ");
//            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            double circ = Circunferencia(raio);
//            double volume = Volume(raio);
//            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
//            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
//            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
//        }
//        static double Circunferencia(double r) {
//            return 2.0 * Pi * r;
//        }
//        static double Volume(double r) {
//            return 4.0 / 3.0 * Pi * r * r * r;
//        }
//    }
//}

//    Triangulo x, y;

//            x = new Triangulo();
//            y = new Triangulo();

//            Console.WriteLine("Entre com as medidas do triângulo X:");
//            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            Console.WriteLine("Entre com as medidas do triângulo Y:");
//            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


//            double areaX = x.Area();
//            double areaY = y.Area();


//            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
//            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

//            if (areaX > areaY) {
//                Console.WriteLine("Maior área: X");
//            }
//            else {
//                Console.WriteLine("Maior área: Y");
//            }


//        }
//    }
//}




