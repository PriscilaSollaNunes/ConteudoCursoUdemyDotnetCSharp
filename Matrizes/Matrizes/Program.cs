﻿using System;
using System.Globalization;
namespace Matrizes {
    class Program {
        static void Main(string[] args) {


            //EXERCICIO 2

            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] == x) {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0) {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1) {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1) {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }



            //EXERCICIO 1 


            //int n = int.Parse(Console.ReadLine());

            //int[,] mat = new int[n, n];

            //for (int i = 0; i < n; i++) {
            //    string[] values = Console.ReadLine().Split(' ');
            //    for (int j = 0; j < n; j++) {
            //        mat[i, j] = int.Parse(values[j]);
            //    }
            //}

            //Console.WriteLine("Main diagonal:");
            //for (int i = 0; i < n; i++) {
            //    Console.Write(mat[i, i] + " ");
            //}
            //Console.WriteLine();

            //int count = 0;
            //for (int i = 0; i < n; i++) {
            //    for (int j = 0; j < n; j++) {
            //        if (mat[i, j] < 0) {
            //            count++;
            //        }
            //    }
            //}
            //Console.WriteLine("Negative numbers: " + count);


            //Demo

            //double[,] mat = new double[2, 3];
            //Console.WriteLine(mat.Length);
            //Console.WriteLine(mat.Rank);
            //Console.WriteLine(mat.GetLength(0));
            //Console.WriteLine(mat.GetLength(1));


        }
    }
}