// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int [] GetArray(int length, int a, int b)
{
    int [] result = new int [length];
    for (int i = 0 ; i< length ; i++)
    {
        result[i]= new Random().Next(a,b);
    }
    return result;
}

void PrintArray(int[] array)
{
    int length = array.Length;
    for (int i=0; i<length; i++)
    {
        Console.Write($"{array[i]}   ");
    }
    
    Console.WriteLine();
}

void Сhetnost(int[] array)
{
int count = 0;
for (int i=0; i<array.Length; i++)
{
    if (array[i]% 2 == 0) 
    count ++;
}
Console.WriteLine(count);
}

int [] array = GetArray(6,10,200);
PrintArray(array);
Сhetnost(array);