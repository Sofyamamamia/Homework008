using System;

class Program 
{ 
    static void Main(string[] args) 
    { 
        int[,,] array = CreateArray(); 
        PrintArray(array); 
    } 
 
    static int[,,] CreateArray() 
    { 
        int[,,] array = new int[2, 2, 2]; 

        Random random = new Random();

        for (var i = 0; i < 2; i++) 
        { 
            for (var j = 0; j < 2; j++) 
            { 
                for (var k = 0; k < 2; k++) 
                { 
                    int element = 0;

                    do
                    {
                        element = random.Next(10, 100);
                    } while (ArrayContains(array, element));

                    array[i, j, k] = element; 
                } 
            } 
        } 

        return array; 
    } 

    static bool ArrayContains(int[,,] array, int element)
    {
        for (var i = 0; i < array.GetLength(0); i++) 
        { 
            for (var j = 0; j < array.GetLength(1); j++) 
            { 
                for (var k = 0; k < array.GetLength(2); k++) 
                { 
                    if (array[i, j, k] == element)
                    {
                        return true;
                    }
                } 
            } 
        }

        return false;
    }
 
    static void PrintArray(int[,,] array) 
    { 
        for (var i = 0; i < 2; i++) 
        { 
            for (var j = 0; j < 2; j++) 
            { 
                for (var k = 0; k < 2; k++) 
                { 
                    Console.Write($"{array[i, j, k]}({i},{j},{k}) "); 
                } 

                Console.WriteLine(); 
            } 
        } 
    } 
}
