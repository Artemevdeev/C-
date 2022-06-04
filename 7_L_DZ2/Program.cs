// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.



int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {   
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }        
    }
    return arr;
}

void Print(int[,] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j <arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]} ");
        } 
        Console.WriteLine();       
    }
    Console.WriteLine();
}

void SeachElement (int [,] array)
{  
    Console.WriteLine(" Введите номер строки");
    int row = int.Parse(Console.ReadLine());
    Console.WriteLine(" Введите номер столбца");
    int column = int.Parse(Console.ReadLine());
    
    if (row >array.GetLength(0) || row < 1 || column >array.GetLength(1) ||column < 1 )
    {
        Console.WriteLine("Элемента с такой позицией нет в данном массиве");
    }
    else 
    {
        
        Console.WriteLine($"Значение элемента =  {array[row-1,column-1]}");
        Console.WriteLine();
    }
}

Console.WriteLine(" Введите кол-во строк");
int row = int.Parse(Console.ReadLine());
Console.WriteLine(" Введите кол-во столбцов");
int column = int.Parse(Console.ReadLine());
    
Console.WriteLine();
int [,] array = MassNums (row, column, 3,10);
Print(array);
SeachElement (array);

