// Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)


Console.WriteLine("Введите числовое значение длинны массива");
string isis=Console.ReadLine();
int iss = int.Parse(isis);
int[] arr = new int[iss];
for (int i = 0; i < iss; i++)
{
    arr[i] = new Random().Next(1,100);        
} 
for(int j = 0; j < arr.Length; j++)
{
    Console.Write(arr[j].ToString() + " ");
}

