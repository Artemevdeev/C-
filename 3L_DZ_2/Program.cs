

//  Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Sum(int num)
{
    int summ=0;
    string len = num.ToString(); 
    for(int j=0;j<len.Length;j++)
    {
        int num1 = num % 10;
        num = num / 10;
        summ= summ +num1;
    }
    return summ;
}

Console.WriteLine("Введите число");
string isis=Console.ReadLine();
int iss = int.Parse(isis);
Console.WriteLine(Sum(iss));
