// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.[3, 7, 22, 2, 78] -> 76


double Max (double [] array) 
{ 
 double max = array[0];
 for (int i = 0; i < array.Length; i++)
 {
 if(array[i] > max) max = array[i]; 
} 
 return max; 
} 
 
double Min (double[] array) 
{ 
 double min = array[0]; 
 for (int i=0; i < array.Length; i++)
 {
 if(array[i] < min) min = array[i]; 
} 
 return min; 
} 
double[] array = new double[3] {30.027, 88.385, 62.654};
Console.WriteLine($" min = {Min(array)}");
Console.WriteLine($" max = {Max(array)}");
Console.WriteLine($" max - min = {Max(array)-Min(array)}");

// double [] GetArray(int length,int min, int max)
// {
//     double [] result = new double [length];
//     for (int i = 0 ; i< length ; i++)
//     {
//         double desdrob = new Random().Next(min,max);
//         result[i]= desdrob/1000; 
//     }
// }

// void PrintArray(double[] array)
// {
//     int length = array.Length;
//     for (int i=0; i<length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// double DifferenceMaxMin(double[] array)
// {
//     int length = array.Length;
//     double min, max;
//     min = max = 0;
//     if(array[0]>array[1])
//  {min = array[1]; max = array[0];}
//     else {min = array[0]; max = array[1];}
//     for (int i=0; i<length; i++)
//     {
//         if(array[i]>max)
//         {max = array[i];}
//         if(array[i]<min)
//         {min = array[i];}        
//     }
//     Console.WriteLine($"min = {min}, max = {max}");
//     Console.WriteLine("");
//     return (max - min);
// }
// double [] array = GetArray(6, 10000, 99999); //(длинна массива, мин значение рандома, макс значение рандома)
// PrintArray(array);
// Console.WriteLine($"max - min = {DifferenceMaxMin(array)}");