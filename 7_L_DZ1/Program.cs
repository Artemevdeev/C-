// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.



// double [,] MassNums  (int row, int column, double from,  double to)
// {
//     double [,] arr = new double [row, column];

//     for (int i = 0; i < row; i++)
//     {   
//         for (int j = 0; j < column; j++)
//         {
//             arr[i, j] = new Random().Next(from, to);
//         }        
//     }
//     return arr;
// }

// void Print(double [,] arr)
// {
//     int row_size = arr.GetLength(0);
//     int column_size = arr.GetLength(1);

//     for (int i = 0; i < row_size; i++)
//     {
//         for (int j = 0; j < column_size; j++)
//         {
//             Console.Write($" {arr[i, j]} ");
//         } 
//         Console.WriteLine();       
//     }
//     Console.WriteLine();
// }


// double [,] arr_1 = MassNums(2, 5, 0.25, 0.38);
// Print(arr_1);

//  double [,] a = new double[5, 10];
 
//             Random random = new Random();
//             for (int i = 0; i < 5; i++)
//             {
//                 for (int j = 0; j < 10; j++)
//                 {
//                     a[i, j] = random.Next(0.12);
//                     Console.Write("{0,4}", a[i, j]);
//                 }
//                 Console.WriteLine();
//             }

// double[,] a = new double[5, 10];
// Random random = new Random();
// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 10; j++)
//     {
//         a[i, j] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
//         Console.Write("{0,6:F2}", a[i, j]);
//     }
//     Console.WriteLine();
// }



double [,] MassNums  (int row, int column)
{
    double [,] arr = new double [row, column];
    Random random = new Random();
    for (int i = 0; i < row; i++)
    {   
        for (int j = 0; j < column; j++)
        {
          arr[i, j] = random.NextDouble() * 100;
          Console.Write("{0,6:F2}   ", arr[i, j]);
        }       
        Console.WriteLine(); 
    }
    return arr; 
}

MassNums (5,3);
