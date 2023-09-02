/*Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить 
строку с наименьшей суммой элементов.*/


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите необходимое количество строк: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Введите необходимое количество столбцов: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] array = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            Console.Write($"Введите элементы для строки {i + 1}: ");
            string[] input = Console.ReadLine().Split();
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = int.Parse(input[j]);
            }
        }

        int minSumRow = FindMinSumRow(array);
        Console.WriteLine($"Номер строки с наименьшей суммой: {minSumRow + 1}");
    }

    static int FindMinSumRow(int[,] array)
    {
        int minSum = int.MaxValue;
        int minSumRow = -1;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int rowSum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                rowSum += array[i, j];
            }
            if (rowSum < minSum)
            {
                minSum = rowSum;
                minSumRow = i;
            }
        }
        return minSumRow;
    }
}
