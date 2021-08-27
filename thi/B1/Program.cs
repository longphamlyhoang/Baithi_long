using System;

namespace B1
{
    class Program
    {
        public static int[,] matrix;
        public static int m;
        public static int n;
        static void Main(string[] args)
        {
            Console.Write(" Nhap so dong: ");
            m = int.Parse(Console.ReadLine());
            Console.Write(" Nhap so cot: ");
            n = int.Parse(Console.ReadLine());
            matrix = CreateMatrix(m, n);
            Display(matrix, m, n);
            FindMax(matrix, m, n);
            Console.WriteLine(FindMax(matrix, m, n));
            ShowMatrix(matrix,m,n);

        }
        static int[,] CreateMatrix(int m, int n)
        {
            int[,] matrix = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int h = 0; h < n; h++)
                {
                    Console.Write(" Nhap phan tu : " + i + " - " + h + " : ");
                    int t = int.Parse(Console.ReadLine());
                    matrix[i, h] = t;
                }
            }
            return matrix;
        }
        static int FindMax(int[,] arr, int m, int n)
        {
            int max = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }
            return max;
        }
        static void ShowMatrix(int[,] arr ,int m,int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i >= j)
                    {
                        Console.Write($"{arr[i,j]}");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine("");
            }
        }
        static void Display(int[,] arr, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
