//  Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3



Console.WriteLine("Введите колличество чисел");

int num = int.Parse(Console.ReadLine());
int count  = 0;
for(int i=0; i<num;i++)
{
    Console.WriteLine("Введите число");
    int num1 = int.Parse(Console.ReadLine());
    if(num1>0) count++;
}
Console.WriteLine($"Кол-во положительных чисел {count}");