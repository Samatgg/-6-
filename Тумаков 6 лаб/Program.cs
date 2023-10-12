using System;
namespace Тумаков_6_лаб
{
    internal class Program
    {
        static int[,] result(int[,] a, int[,] b) // Для упр 6.2
        {
            int str1 = a.GetLength(0);
            int col1 = a.GetLength(1);
            int str2 = b.GetLength(0);
            int col2 = b.GetLength(1);
            if (str1 != col2)
            {
                Console.WriteLine("Кол-во строк одной матрицы не совпадает с кол-вом столбцов второй матрицы");
            }
            int[,] result = new int[str1, col2];
            for (int i = 0; i < str1; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    for (int k = 0; k < col1; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return result;
        }
        static void Print(int[,] matrix) // Для упражнения 6.2
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {   // Упр 6.2 - Написать программу, реализующую произведение двух матриц, заданных в виде двумерного массива
            Console.WriteLine("Упр 6.2 - Написать программу, реализующую произведение двух матриц, заданных в виде двумерного массива\n");
            int[,] matrix1 =
            {
                {4,2,3},
                {3,5,9}
            };
            Console.WriteLine("Первая матрица: ");
            Print(matrix1);
            int[,] matrix2 =
            {
                {4,2},
                {1,4},
                {8,5},
            };
            Console.WriteLine("Вторая матрица: ");
            Print(matrix2);
            int[,] otvet = result(matrix1, matrix2);
            Console.WriteLine("Их произведение равно: ");
            Print(otvet);

            // Упр 6.3 - Средняя температура каждого месяца
            Console.WriteLine("\nУпр 6.3 - Средняя температура каждого месяцa\n");
            int[,] temp = new int[12, 30];
            Random random = new Random();
            for (int month = 0; month < 12; month++)
            {
                for (int day = 0; day < 30; day++)
                {
                    temp[month, day] = random.Next(-30, 30);
                }
            }
            int[] sr_temp = new int[12];
            for (int month = 0; month < 12; month++)
            {
                int sum = 0;
                for (int day = 0; day < 30; day++)
                {
                    sum += temp[month, day];
                }
                sr_temp[month] = sum / 30;
            }
            Array.Sort(sr_temp);
            for (int month = 0; month < 12; month++)
            {
                Console.WriteLine($"В {month + 1} месяце средняя температура составляет {sr_temp[month]} градусов");
            }
        }
    }
}
