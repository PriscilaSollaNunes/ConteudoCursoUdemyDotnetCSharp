using SesaoSeis;
using System;
using System.Globalization;
using System.Net.Http.Headers;
namespace SessaoSeis {
    class Program {
        static void Main(string[] args) { 

            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for (int i = 0; i < n; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto { Name = name, Price = price } ;
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                sum += vect[i].Price;   
            }

            double avg = sum / n;
            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}



























//            int n = int.Parse(Console.ReadLine());
//            double[] vect = new double[n];
//            for (int i = 0; i < n; i++) {
//                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            }
//            double sum = 0.0;
//            for (int i = 0; i < n; i++) {
//                sum += vect[i];
//            }
//            double avg = sum / n;
//            Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));

//        }
//    }
//}

//            double? x = null;       
//            double? y = 10;

//            double a = x ?? 5;
//            double b = y ?? 5;

//            Console.WriteLine(a);
//            Console.WriteLine(b);


//        }
//    }
//}














//            double? x = null;
//            double? y = 10;

//            Console.WriteLine(x.GetValueOrDefault());
//            Console.WriteLine(y.GetValueOrDefault());

//            Console.WriteLine(x.HasValue);
//            Console.WriteLine(y.HasValue);


//            if (x.HasValue)
//                Console.WriteLine(x.Value);
//            else
//                Console.WriteLine("X is null");

//            if (y.HasValue)
//                Console.WriteLine(y.Value);
//            else 
//                Console.WriteLine("Y is null");




//            //Point p;
//            //p.X = 10;
//            //p.Y = 20;


//            //Console.WriteLine(p);
//        }
//    }
//}
