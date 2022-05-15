// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int num1 = 0;
int num2 = 0;

void secondNumber( int num)
{
    Console.Write(num);
    num1 = num/ 100;
    num2 = num %10;
    Console.WriteLine($" ==>  {num1}{num2}"); 
    
}
secondNumber(new Random().Next(100,1000));
secondNumber(new Random().Next(100,1000));
secondNumber(new Random().Next(100,1000));
