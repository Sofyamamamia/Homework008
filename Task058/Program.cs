/*Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.*/

using System; 

class Program 
{    
    static void Main(string[] args) 
    {        
        int[,] matrixA = ReadMatrix("A"); 
        int[,] matrixB = ReadMatrix("B"); 
        
        if (matrixA.GetLength(1) != matrixB.GetLength(0)) 
        {            
            Console.WriteLine("Вычисление невозможно, так как количество столбцов и строк матриц не равны."); 
            return;        
        } 
        
        int[,] resultMatrix = MultiplyMatrices(matrixA, matrixB); 
        
        PrintMatrix(resultMatrix); 
    }
    
    static int[,] ReadMatrix(string name)
    {
        Console.Write($"Введите необходимое количество строк для матрицы {name}: "); 
        int rows = int.Parse(Console.ReadLine());        
        Console.Write($"Введите необходимое количество столбцов для матрицы {name}: "); 
        int columns = int.Parse(Console.ReadLine()); 
        
        int[,] matrix = new int[rows, columns]; 
        
        for (int i = 0; i < rows; i++)        
        { 
            Console.Write($"Введите элементы для строки {i + 1} матрицы {name}: ");            
            string[] input = Console.ReadLine().Split(); 
            
            for (int j = 0; j < columns; j++)            
            { 
                matrix[i, j] = int.Parse(input[j]);            
            } 
        } 
        
        return matrix;
    }
    
    static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rowsA = matrixA.GetLength(0);
        int columnsA = matrixA.GetLength(1);
        int rowsB = matrixB.GetLength(0);
        int columnsB = matrixB.GetLength(1);
        
        int[,] resultMatrix = new int[rowsA, columnsB]; 
        
        for (int i = 0; i < rowsA; i++) 
        {            
            for (int j = 0; j < columnsB; j++) 
            {                
                int sum = 0; 
                
                for (int k = 0; k < columnsA; k++) 
                {                    
                    sum += matrixA[i, k] * matrixB[k, j]; 
                }                
                
                resultMatrix[i, j] = sum; 
            }        
        } 
        
        return resultMatrix;
    }
    
    static void PrintMatrix(int[,] matrix)
    {
        Console.WriteLine("Результат:"); 
        
        for (int i = 0; i < matrix.GetLength(0); i++)        
        { 
            for (int j = 0; j < matrix.GetLength(1); j++)            
            { 
                Console.Write($"{matrix[i, j]} ");            
            } 
            
            Console.WriteLine();        
        } 
    }
}