// Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.


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
 void SumNechetPosit(int[] array)
{
int sum = 0;
for (int i=0; i<array.Length; i+=2)
{
    sum = sum + array[i];
}
Console.WriteLine(sum);
}


int [] array = GetArray(6,-10,10);
PrintArray(array);
SumNechetPosit(array);
