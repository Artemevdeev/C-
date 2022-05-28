// //  Задача 4: Напишите программу, которая будет создавать копию заданного двумерного массива 
// //  с помощью поэлементного копирования.

// int[,] array1 = new int [2,5] {{3,7,9,8,4},{6,8,4,2,6}};
// int[,] array2 = new int [2,5] {{0,0,0,0,0},{0,0,0,0,0}};


// void PrintArray (int [,] arr)
// {
//     for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         Console.Write("        ");
//         for(int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($" {arr[i,j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void CopyArray (int [,] arr1, int [,] arr2)
// {
//     for(int i = 0; i < arr1.GetLength(0); i++)
//     {
//         for(int j = 0; j < arr1.GetLength(1); j++)
//         {
//              arr2[i,j] = arr1[i,j];
//         }
//         Console.WriteLine();
//     }
// }



// Console.WriteLine("array1 = ");

// PrintArray(array1);
// Console.WriteLine("array2 = ");
// PrintArray(array2);
// Console.WriteLine("Копирование массива... ");
// CopyArray(array1,array2);
// Console.WriteLine("array1 = ");
// PrintArray(array1);
// Console.WriteLine("array2 = ");
// PrintArray(array2);