using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = CreateArray();
        PrintArray(array);
        SortRowsDescending(array);
        Console.WriteLine("Сортировка:");
        PrintArray(array);
    }

    static int[,] CreateArray()
    {
        Console.Write("Введите необходимое количество строк: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Введите необходимое количество столбцов: ");
        int columns = int.Parse(Console.ReadLine());
        int[,] array = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Введите элемент [{i}, {j}]: ");
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }
        return array;
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void SortRowsDescending(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                for (int k = j + 1; k < array.GetLength(1); k++)
                {
                    if (array[i, j] < array[i, k])
                    {
                        int temp = array[i, j];
                        array[i, j] = array[i, k];
                        array[i, k] = temp;
                    }
                }
            }
        }
    }
}