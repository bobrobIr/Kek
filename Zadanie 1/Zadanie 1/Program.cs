using System;

class Program
{
    static void Main()
    {
        string da;
        do
        {
            Console.WriteLine("Выберите номер задания");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    {
                        int n, m;
                        Console.Write("Введите количество строк (n): ");
                        n = int.Parse(Console.ReadLine());
                        Console.Write("Введите количество столбцов (m): ");
                        m = int.Parse(Console.ReadLine());
                        double[,] matrix1 = new double[n, m];

                        // Ввод матрицы построчно
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"Введите элементы строки {i + 1}:");
                            for (int j = 0; j < m; j++)
                            {
                                Console.Write($"Элемент [{i},{j}]: ");
                                matrix1[i, j] = double.Parse(Console.ReadLine());
                            }
                        }

                        // Вывод матрицы по столбцам
                        Console.WriteLine("Матрица по столбцам:");
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                Console.Write(matrix1[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    break;
                case 2:
                    {
                        Console.Write("Введите размерность квадратной матрицы n: ");
                        int n = int.Parse(Console.ReadLine());
                        double[,] matrix = new double[n, n];
                        double[,] transposedMatrix = new double[n, n];

                        // Заполнение матрицы случайными вещественными числами
                        Random random = new Random();
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                matrix[i, j] = Math.Round(random.NextDouble() * 10, 2);
                            }
                        }

                        Console.WriteLine("Исходная матрица:");
                        PrintMatrix(matrix);

                        // Транспонирование матрицы
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                transposedMatrix[i, j] = matrix[j, i];
                            }
                        }

                        Console.WriteLine("Транспонированная матрица:");
                        PrintMatrix(transposedMatrix);


                        static void PrintMatrix(double[,] matrix)
                        {
                            int n = matrix.GetLength(0);
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    Console.Write(matrix[i, j] + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                    break;


            }
            Console.WriteLine("Хочешь проходолжить?: ");
            da = Console.ReadLine();
        } while (da == "да");
    }
}
















        