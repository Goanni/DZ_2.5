using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2._5
{
    internal class DZ_5
    {
        static public void Main()
        {
            Console.WriteLine("Размерность матрицы n*n. Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array1 = new int[n * n];
            int[] array2 = new int[n * n];
            int[] result = new int[n * n];
            int index_arr = 0;

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    array1[index_arr] = rnd.Next(10);
                    Console.Write($"{array1[index_arr]}\t");
                    index_arr++;
                }
            }
            index_arr = 0;

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    array2[index_arr] = rnd.Next(10);
                    Console.Write($"{array2[index_arr]}\t");
                    index_arr++;
                }
            }
            index_arr = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        result[i * n + j] += array1[i * n + k] * array2[k * n + j];

                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("\nМатрица после умножения");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{result[index_arr]}\t");
                    index_arr++;
                }
            }
        }
    }
}
    

