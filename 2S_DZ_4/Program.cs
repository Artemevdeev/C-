﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.


void DayNumber(int num)
{
    if(num >=1 & num <= 5)
    {
        Console.WriteLine(" - Рабочий день");
    }
    if(num >=6 & num <= 7)
    {
        Console.WriteLine(" - Выходной день");
    }
}

Console.WriteLine("Введите цифру дня недели");
string isis=Console.ReadLine();
int iss = int.Parse(isis);
DayNumber(iss);