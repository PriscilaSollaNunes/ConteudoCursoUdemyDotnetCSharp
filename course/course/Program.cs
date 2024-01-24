
using System;
using System.Globalization;


namespace Course {
    internal class Program {
        static void Main(string[] args) {

            
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
                    x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("Entre com as medidas do triângulo Y:");
                    y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                    double p = (x.A + x.B + x.C) / 2.0;
                    double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

                    p = (y.A + y.B + y.C) / 2.0;
                    double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

                    Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
                    Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) {
                Console.WriteLine("Maior área: X");
            }
            else {
                Console.WriteLine("Maior área: Y");
            }


        }
    }
}

//        double xA, xB, xC, yA, yB, yC;

//        Console.WriteLine("Entre com as medidas do triângulo X:");
//        xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//        xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//        xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


//        Console.WriteLine("Entre com as medidas do triângulo Y:");
//        yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//        yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//        yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


//        double p = (xA + xB + xC) / 2.0;
//        double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

//        p = (yA + yB + yC) / 2.0;
//        double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

//        Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
//        Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

//        if (areaX > areaY) {
//            Console.WriteLine("Maior área: X");
//        }
//        else {
//            Console.WriteLine("Maior área: Y");
//        }

//    }
//    //}
//}



//            Console.Write("Quantos números inteiros você vai digitar? ");
//            int N = int.Parse(Console.ReadLine());

//            int soma = 0;
//            for (int i = 1; i <= N; i++) {
//                Console.Write("Valor #{0}: ", i);
//                int valor = int.Parse(Console.ReadLine());
//                soma += valor;

//            }

//            Console.WriteLine("Soma = " + soma);

//        }
//    }
//}

// Aula 32 - While

//            Console.Write("Digite um número: ");
//            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            while (x >= 0.0) {
//                double raiz = Math.Sqrt(x);
//                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
//                Console.Write("Digite um número: ");
//                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            }

//            Console.WriteLine("Número negativo!");

//        }
//    }
//}

// aula 30 - Funções

//            Console.WriteLine("Digite três números:");
//            int n1 = int.Parse(Console.ReadLine());
//            int n2 = int.Parse(Console.ReadLine());
//            int n3 = int.Parse(Console.ReadLine());


//            double resultado = Maior(n1, n2, n3);

//            Console.WriteLine("Maior = " + resultado);

//        }

//        static int Maior(int a, int b, int c) {
//            int m;
//            if (a > b && a > c) {
//                m = a;
//            }
//            else if (b > c) {
//                m = b;
//            }
//            else {
//                m = c;
//            }
//            return m;
//        }

//    }

//}


//if (n1 > n2 && n1 > n3) {
//    Console.WriteLine("Maior = " + n1);
//}

//else if (n2 > n3) {
//    Console.WriteLine("Maior = " + n2);
//}

//else {
//    Console.WriteLine("Maior = " + n3);
//}










// aula 22 e 23 - Entrada de dados em C# 

//Console.WriteLine("Entre com seu nome completo:");
//string nome = Console.ReadLine();
//Console.WriteLine("Quantos quartos tem na sua casa?");
//int quartos = int.Parse(Console.ReadLine());
//Console.WriteLine("Entre com o preço de um produto:");
//double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
//Console.WriteLine("Entre seu último nome,idade e altura (mesma linha):");
//string[] vet = Console.ReadLine().Split();
//string sobrenome = vet[0];
//int idade = int.Parse(vet[1]);
//double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);


//Console.WriteLine(nome);
//Console.WriteLine(quartos);
//Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
//Console.WriteLine(sobrenome);
//Console.WriteLine(idade);
//Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));






//int n1 = int.Parse(Console.ReadLine());
//char ch = char.Parse(Console.ReadLine());
//double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//string[] vet = Console.ReadLine().Split();
//string nome = vet[0];
//char sexo = char.Parse(vet[1]);
//int idade = int.Parse(vet[2]);
//double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

//Console.WriteLine("Você digitou:");
//Console.WriteLine(n1);
//Console.WriteLine(ch);
//Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
//Console.WriteLine(nome);
//Console.WriteLine(sexo);
//Console.WriteLine(idade);
//Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));


//string frase = Console.ReadLine();
//string x = Console.ReadLine();
//string y = Console.ReadLine();
//string z = Console.ReadLine();


//string[] v = Console.ReadLine().Split();
//string a = v[0];
//string b = v[1];      
//string c = v[2];  



//Console.WriteLine("Você digitou: ");


//Console.WriteLine(frase);
//Console.WriteLine(x);
//Console.WriteLine(y);
//Console.WriteLine(z);
//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);





// aula 21 - operadores aritméticos

//int n1 = 3 + 4 * 2;
//int n2 = (3 + 4) * 2;
//int n3 = 17 % 3;
//double n4 = (double) 10 / 8;

//double a = 1.0, b = -3.0, c = -4.0;

//double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

//double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
//double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);


//Console.WriteLine(n1);
//Console.WriteLine(n2);
//Console.WriteLine(n3);
//Console.WriteLine(n4);
//Console.WriteLine(delta);
//Console.WriteLine(x1);
//Console.WriteLine(x2);


//aula 20 - conversão implícita e casting 


//int a = 5;
//int b = 2;

//double resultado = (double)a / b;

//Console.WriteLine(resultado);















//double a;
//int b;

//a = 5.1;
//b = (int)a;

//Console.WriteLine(b);


//double a;
//float b;

//a = 5.1;
//b = (float)a;

//Console.WriteLine(b);




//float x = 4.5f;

//double y = x;

//Console.WriteLine(y);











// string produto1 = "Computador";
//string produto2 = "Mesa de escritório";

//byte idade = 30;
//int codigo = 5290;
//char genero = 'M';

//double preco1 = 2100.0;
//double preco2 = 650.50;
//double medida = 53.234567;

//Console.WriteLine("Produtos:");
//Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
//Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}");
//Console.WriteLine();
//Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
//Console.WriteLine();
//Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
//Console.WriteLine($"Arredondado (três cadsa decimais): {medida:F3}");
//Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));


//        //}
//    }
//}
