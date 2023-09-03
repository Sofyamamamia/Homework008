using System;
using System.Linq;

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
        int rows = 0;
        int columns = 0;
        bool isRowsValid = false;
        bool isColumnsValid = false;

        while (!isRowsValid)
        {
            Console.Write("Введите необходимое количество строк: "); 
            isRowsValid = int.TryParse(Console.ReadLine(), out rows);
        }

        while (!isColumnsValid)
        {
            Console.Write("Введите необходимое количество столбцов: "); 
            isColumnsValid = int.TryParse(Console.ReadLine(), out columns);
        }

        int[,] array = new int[rows, columns]; 

        for (var i = 0; i < rows; i++) 
        { 
            for (var j = 0; j < columns; j++) 
            { 
                bool isElementValid = false;
                int element = 0;

                while (!isElementValid)
                {
                    Console.Write($"Введите элемент [{i}, {j}]: "); 
                    isElementValid = int.TryParse(Console.ReadLine(), out element);
                }

                array[i, j] = element; 
            } 
        } 

        return array; 
    } 
 
    static void PrintArray(int[,] array) 
    { 
        for (var i = 0; i < array.GetLength(0); i++) 
        { 
            for (var j = 0; j < array.GetLength(1); j++) 
            { 
                Console.Write($"{array[i, j]} "); 
            } 

            Console.WriteLine(); 
        } 
    } 
 
    static void SortRowsDescending(int[,] array) 
    { 
        for (var i = 0; i < array.GetLength(0); i++) 
        { 
            var row = Enumerable.Range(0, array.GetLength(1))
                                 .Select(j => array[i, j])
                                 .OrderByDescending(x => x)
                                 .ToArray();

            for (var j = 0; j < array.GetLength(1); j++) 
            { 
                array[i, j] = row[j];
            } 
        } 
    } 
}