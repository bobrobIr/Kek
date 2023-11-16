using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Никитин_Р
{
    internal class Program
    //{
        ////        Задание 1
        //        static void Main()
        //        {
        //            Console.WriteLine("Введите количество строк массива");
        //            int n = int.Parse(Console.ReadLine());
        //            Console.WriteLine("Введите количество столбцов массива");
        //            int m = int.Parse(Console.ReadLine());
        //            int[,] a = new int[n, m];



        //            for (int i = 0; i < n; i++)

        //                for (int j = 0; j < m; j++)
        //                {

        //                    Console.WriteLine("Введите X{0},{1} эллемент массива A", i, j);
        //                    a[i, j] = Convert.ToInt32(Console.ReadLine());


        //                }

        //            for (int i = 0; i < n; i++)
        //            {
        //                Console.WriteLine();
        //                for (int j = 0; j < m; j++)
        //                {
        //                    Console.Write("{0}\t", a[i, j]);

        //                }
        //            }
        //            Console.ReadKey();
        //        }
        //    }
        //}

        //        //Задание 4
        //        class matrix
        //        {
        //            int size;
        //            double[,] arr;

        //            public matrix(double[,] a, int n)
        //            {
        //                arr = a;
        //                size = n;
        //            }

        //            public void swap()
        //            {
        //                double tmp;
        //                for (int i = 0; i < size; i++)
        //                {
        //                    for (int j = 0; j < i; j++)
        //                    {
        //                        tmp = arr[i, j];
        //                        arr[i, j] = arr[j, i];
        //                        arr[j, i] = tmp;
        //                    }
        //                }
        //            }

        //            public void print()
        //            {
        //                for (int i = 0; i < size; i++)
        //                {
        //                    for (int j = 0; j < size; j++)
        //                        Console.Write(arr[i, j] + " ");
        //                    Console.WriteLine();
        //                }
        //            }
        //        }

        //        class program
        //        {
        //            public static void Main()
        //            {
        //                Console.Write("Введите размер матрицы: ");
        //                int size = Convert.ToInt32(Console.ReadLine());
        //                double[,] arr = new double[size, size];
        //                Console.WriteLine("Заполните матрицу: ");

        //                for (int i = 0; i < size; i++)
        //                {
        //                    string[] str_arr = (Console.ReadLine()).Split(' ');
        //                    for (int j = 0; j < size; j++)
        //                        arr[i, j] = Convert.ToDouble(str_arr[j]);
        //                }
        //                matrix ob = new matrix(arr, size);

        //                Console.WriteLine("\nИсходная матрица: ");

        //                ob.print();

        //                Console.WriteLine("\nТранспонированная матрица: ");
        //                ob.swap();
        //                ob.print();
        //                Console.ReadKey();
        //            }
        //        }
        //    }
        //}
//        //Задание 5
//        class Program
//        {
//            static void Main(string[] args)
//            {
//                Console.WriteLine("Введите размерность массива");
//                int N = int.Parse(Console.ReadLine());
//                int[,] matrix = new int[N, N];
//                int sum1 = 0; int sum2 = 0;

//                Random rnd = new Random();
//                for (int i = 0; i < N; i++)
//                {
//                    for (int t = 0; t < N; t++)
//                    {
//                        matrix[i, t] = rnd.Next(0, 10);
//                        Console.Write(matrix[i, t] + "\t");
//                    }
//                    Console.WriteLine();
//                }

//                for (int i = 0; i < N; i++)
//                {
//                    sum1 += matrix[i, i];
//                    sum2 += matrix[i, N - i - 1];
//                }
//                Console.WriteLine("{0}   {1}", sum1, sum2);
//                Console.ReadKey();
//            }
//        }
//    }
//}