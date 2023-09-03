using System;

class Program 
{ 
    static void Main(string[] args) 
    { 
        Console.WriteLine("Введите размер массива:");
        int size = int.Parse(Console.ReadLine());
        int[,] array = CreateSpiralArray(size); 
        PrintArray(array); 
    } 
 
    static int[,] CreateSpiralArray(int size) 
    { 
        int[,] array = new int[size, size]; 

        int value = 1; 
        int rowStart = 0; 
        int rowEnd = size - 1; 
        int colStart = 0; 
        int colEnd = size - 1; 

        while (rowStart <= rowEnd && colStart <= colEnd) 
        { 
            value = FillTopRow(array, rowStart, colStart, colEnd, value);
            value = FillRightColumn(array, colEnd, rowStart + 1, rowEnd, value);
            if (rowStart < rowEnd && colStart < colEnd) 
            { 
                value = FillBottomRow(array, rowEnd, colStart, colEnd - 1, value);
                value = FillLeftColumn(array, colStart, rowStart + 1, rowEnd - 1, value);
            } 

            rowStart++; 
            rowEnd--; 
            colStart++; 
            colEnd--; 
        } 

        return array; 
    } 

    static int FillTopRow(int[,] array, int row, int startCol, int endCol, int value)
    {
        for (int i = startCol; i <= endCol; i++)
        {
            array[row, i] = value++;
        }

        return value;
    }

    static int FillRightColumn(int[,] array, int col, int startRow, int endRow, int value)
    {
        for (int i = startRow; i <= endRow; i++)
        {
            array[i, col] = value++;
        }

        return value;
    }

    static int FillBottomRow(int[,] array, int row, int startCol, int endCol, int value)
    {
        for (int i = endCol; i >= startCol; i--)
        {
            array[row, i] = value++;
        }

        return value;
    }

    static int FillLeftColumn(int[,] array, int col, int startRow, int endRow, int value)
    {
        for (int i = endRow; i >= startRow; i--)
        {
            array[i, col] = value++;
        }

        return value;
    }
 
    static void PrintArray(int[,] array) 
    { 
        for (var i = 0; i < array.GetLength(0); i++) 
        { 
            for (var j = 0; j < array.GetLength(1); j++) 
            { 
                Console.Write($"{array[i, j]:00} "); 
            } 

            Console.WriteLine(); 
        } 
    } 
}