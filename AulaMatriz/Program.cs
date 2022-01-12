﻿using System;

namespace AulaMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) // linhas
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++) // colunas
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.Write("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Negative numbers: {count}");
        }
    }
}
