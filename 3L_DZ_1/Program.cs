// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
 

 int СubeNum(int a, int b) // 2 и 3
{
    int all = a; // 2
    {
    for (int i = 1; i < b; i++)// i = 1 // i =2/ i = 3
    {

        all =  all * a; // 2 = 2*2 = 4,4 * 2= 8// 8 * 2 = 16 

        
    }
    return all;

    }
}



Console.WriteLine(СubeNum(2,1));
Console.WriteLine(СubeNum(2,2));
Console.WriteLine(СubeNum(2,3));
Console.WriteLine(СubeNum(2,4));

 

 